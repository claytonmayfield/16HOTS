using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesOrdersApp.Models;

namespace SalesOrdersApp.Controllers
{
    public class CustomerController : Controller
    {
        private SalesOrderContext context { get; set; }

        //  ProductController Constructor
        public CustomerController(SalesOrderContext ctx)
        {
            context = ctx;
        }

        [Route("Customers/")]
        public IActionResult List()
        {
            var customers = context.Customers
                .OrderBy(c => c.CustomerLastName).ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Customers = context.Customers
                                        .OrderBy(c => c.CustomerFirstName)
                                        .ToList();
            return View("AddEdit", new Customer());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var customers = context.Customers.Find(id);
            ViewBag.Customers = context.Customers
                                        .OrderBy(c => c.CustomerLastName)
                                        .ToList();
            return View("AddEdit", customers);
        }

        [HttpPost]
        public IActionResult Save(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerID == 0)
                {
                    context.Customers.Add(customer);
                }
                else
                {
                    context.Customers.Update(customer);
                }

                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                if (customer.CustomerID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }

                return View(customer);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
