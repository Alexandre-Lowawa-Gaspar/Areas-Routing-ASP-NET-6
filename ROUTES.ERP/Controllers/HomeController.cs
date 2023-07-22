using Microsoft.AspNetCore.Mvc;

namespace ROUTES.ERP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
