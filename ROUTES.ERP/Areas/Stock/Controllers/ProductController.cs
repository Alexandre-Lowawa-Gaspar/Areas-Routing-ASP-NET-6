using Microsoft.AspNetCore.Mvc;

namespace ROUTES.ERP.Areas.Stock.Controllers
{
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

    }
}
