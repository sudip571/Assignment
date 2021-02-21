using Newtonsoft.Json;
using PreAssignment.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace PreAssignment.Services
{
    public class ProductService
    {
        public async Task<DataViewModel> HerokuAPIRequest()
        {   
            var data = new DataViewModel();
            var dt = new DataContext();
            var customerOrder = new List<CustomerrOrder>();
            var res = dt.CustomerrOrders.GroupBy(x => x.Customerr.CustomerrId, (key, element) => element.OrderByDescending(x => x.Date).Take(2)).ToList();
            foreach (var item in res)
            {
                customerOrder.AddRange(item);
            }
            var customer = dt.Customerrs.ToList();
            var result = customer.Join(customerOrder, c => c.CustomerrId, i => i.Customerr.CustomerrId, (c, i) => new { Id = c.CustomerrId, Name = c.Name, Date = i.Date, Qty = i.Qty }).ToList();
            int g = 7;

            try
            {               
                var herokuAPI = @"https://ecommerce-api-with-jwt.herokuapp.com/api/products";
                var apiKey = @"$2y$10$tAajJXlhdqDfGi8CppFN3.KWnofLUVE03gknOyEDv9OBAcypda9MO";
                
                //Make channel secure
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(herokuAPI);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("api-key", apiKey);
                    client.DefaultRequestHeaders.Accept.Add(new
                    System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                    var response = await client.GetAsync(herokuAPI);
                  
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        data = JsonConvert.DeserializeObject <DataViewModel>(responseContent);
                    }
                }
                //saving response to database
                var productList = new List<Product>();
                using (var db = new DataContext())
                {
                    foreach (var product in data.Data)
                    {
                        var model = new Product() {                            
                            Discount = product.Discount,                            
                            Name = product.Name,
                            Rating = product.Rating,
                            TotalPrice = product.TotalPrice,
                            DataRetriveDate = DateTime.Now,
                            HourIndex = DateTime.Now.ToString("hhtt"),//e.g 11AM 12PM
                            Href = new Href
                            {
                                Link = product.Href.Link
                            }

                        };
                        productList.Add(model);
                    }
                    db.Products.AddRange(productList);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {

                Log.Error(ex.Message);
            }
            return data;

        }

    }
}