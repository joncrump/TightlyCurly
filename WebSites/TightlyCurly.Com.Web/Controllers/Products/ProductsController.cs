using System.Web.Mvc;
using TightlyCurly.Com.Web.Models;

namespace TightlyCurly.Com.Web.Controllers.Products
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RecommendedProducts(string category)
        {
            return View(new ProductCategoryModel {Category = category});
        }
    }
}
