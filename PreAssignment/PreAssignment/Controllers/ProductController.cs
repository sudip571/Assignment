using PreAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PreAssignment.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public async  Task<ActionResult> GetProduct()
        {
            var productService = new ProductService();
            var products = await productService.HerokuAPIRequest();
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}