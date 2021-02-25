using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.Country = context.Country.OrderBy(context => context.countryName).ToList();

            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Country = context.Country.OrderBy(context => context.countryName).ToList();

            var customer = context.Customer
                .Include(context => context.customerCountry)
                .FirstOrDefault(context => context.customerId == id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customer
                .FirstOrDefault(context => context.customerId == id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            string action = (customer.customerId == 0) ? "Add" : "Edit";

            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    context.Customer.Add(customer);
                }
                else
                {
                    context.Customer.Update(customer);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Customer");
            }
            else
            {
                ViewBag.Action = action;
                ViewBag.Country = context.Country.OrderBy(context => context.countryName).ToList();
                return View(customer);
            }
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customer.Remove(customer); // remove 
            context.SaveChanges();
            return RedirectToAction("List", "Customer");

        }
    }
}