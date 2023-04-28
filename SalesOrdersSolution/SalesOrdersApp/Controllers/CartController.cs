using Microsoft.AspNetCore.Mvc;
using SalesOrdersApp.Models;

namespace SalesOrdersApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string id)
        {
            ViewBag.ProductSlug = id;
            return View();
        }
    }
}
