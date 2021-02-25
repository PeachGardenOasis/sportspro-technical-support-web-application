using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class ProductController : Controller
    {
        private IncidentContext context { get; set; }

        public ProductController(IncidentContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            var product = context.Product;
            return View(product);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // TO DO
            ViewBag.Action = "Add";
            ViewBag.Product = context.Product.OrderBy(c => c.productName.ToList());
            return View("Edit", new Product());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";

            var product = context.Product
                .FirstOrDefault(context => context.productId == id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Product
                .Include(context => context.productId == id)
                .FirstOrDefault();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            string action = (product.productId == 0) ? "Add" : "Edit";

            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    context.Product.Add(product);
                }
                else
                {
                    context.Product.Update(product);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Product");
            }
            else
            {
                ViewBag.Action = action;
                return View(product);
            }
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Product.Remove(product); // remove 
            context.SaveChanges();
            return RedirectToAction("List", "Product");
        }
    }
}
