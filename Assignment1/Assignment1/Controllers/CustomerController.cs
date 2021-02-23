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
            ViewBag.Customer = context.Customer.OrderBy(c => c.customerFullName.ToList());
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
        public IActionResult Edit(Technician technician)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            return View();
        }
    }
}