using Microsoft.AspNetCore.Mvc;
using ROUTES.ERP.Areas.Stock.Models;

namespace ROUTES.ERP.Areas.Stock.Controllers
{
    [Area("Stock")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult EditProduct() 
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListProduct() 
        {
            
            return View(new List<Product>());
        }

        [HttpPost]
        public IActionResult Delete(int id) 
        {
        return RedirectToAction("ListProduct");
        }
    }
}
