using Microsoft.AspNetCore.Mvc;

namespace SalesOrdersApp.Areas.Customer.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
