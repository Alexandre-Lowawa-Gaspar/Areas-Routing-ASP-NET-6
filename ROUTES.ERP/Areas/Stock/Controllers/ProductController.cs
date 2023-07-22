using Microsoft.AspNetCore.Mvc;

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

    }
}
