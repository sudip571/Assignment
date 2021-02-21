using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreAssignment.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public DateTime DataRetriveDate { get; set; }
        public string HourIndex { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public double TotalPrice { get; set; }
        public string Rating { get; set; }
        
        public  virtual Href Href { get; set; }
    }
}