using Microsoft.AspNetCore.Mvc;
using SalesOrdersApp.Models;

namespace SalesOrdersApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private SalesOrderContext context;

        public CategoryController(SalesOrderContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [Route("[area]/Categories/{id?}")]
        public IActionResult List()
        {
            var categories = context.Categories
                .OrderBy(c => c.CategoryID).ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new Category());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Action = "Update";
            var category = context.Categories.Find(id);
            return View("AddEdit", category);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.CategoryID == 0)
                {
                    context.Categories.Add(category);
                }
                else
                {
                    context.Categories.Update(category);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Action = "Save";
                return View("AddEdit");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Category category = context.Categories.Find(id) ?? new Category();
            return View(category);
        }


        [HttpPost]
        public IActionResult Delete(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
