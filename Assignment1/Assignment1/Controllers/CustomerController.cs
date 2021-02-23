using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class CustomerController : Controller
    {
        private IncidentContext context { get; set; }

        public CustomerController(IncidentContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            var customer = context.Customer;
            return View(customer);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // TO DO
            ViewBag.Action = "Add";
            ViewBag.Customer = context.Customer.OrderBy(c => c.customerLastName.ToList());
            return View("Edit");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customer.Remove(customer); // remove 
            context.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
    }
}