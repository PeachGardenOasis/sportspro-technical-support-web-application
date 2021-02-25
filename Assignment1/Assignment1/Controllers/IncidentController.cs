using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class IncidentController : Controller
    {
        private IncidentContext context { get; set; }

        public IncidentController(IncidentContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            var incident = context.Incident;
            ViewBag.Customer = context.Customer.OrderBy(context => context.customerId).ToList();
            ViewBag.Product = context.Product.OrderBy(context => context.productId).ToList();
            return View(incident);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // TO DO
            ViewBag.Action = "Add";
            ViewBag.Incident = context.Incident.OrderBy(c => c.incidentTitle.ToList());
            ViewBag.Customer = context.Customer.OrderBy(context => context.customerId).ToList();
            ViewBag.Product = context.Product.OrderBy(context => context.productId).ToList();
            ViewBag.Technician = context.Technician.OrderBy(context => context.technicianId).ToList();
            return View("Edit", new Incident());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Incident = context.Incident.OrderBy(c => c.incidentTitle.ToList());
            ViewBag.Customer = context.Customer.OrderBy(context => context.customerId).ToList();
            ViewBag.Product = context.Product.OrderBy(context => context.productId).ToList();
            ViewBag.Technician = context.Technician.OrderBy(context => context.technicianId).ToList();

            var incident = context.Incident
                .FirstOrDefault(context => context.incidentId == id);
            return View(incident);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.Customer = context.Customer.OrderBy(context => context.customerId).ToList();
            ViewBag.Product = context.Product.OrderBy(context => context.productId).ToList();
            ViewBag.Technician = context.Technician.OrderBy(context => context.technicianId).ToList();

            var incident = context.Incident
                .FirstOrDefault(context => context.incidentId == id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            string action = (incident.incidentId == 0) ? "Add" : "Edit";

            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    context.Incident.Add(incident);
                }
                else
                {
                    context.Incident.Update(incident);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Incident");
            }
            else
            {
                ViewBag.Action = action;
                ViewBag.Incident = context.Incident.OrderBy(c => c.incidentTitle.ToList());
                ViewBag.Customer = context.Customer.OrderBy(context => context.customerId).ToList();
                ViewBag.Product = context.Product.OrderBy(context => context.productId).ToList();
                ViewBag.Technician = context.Technician.OrderBy(context => context.technicianId).ToList();
                return View(incident);
            }
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            context.Incident.Remove(incident); // remove 
            context.SaveChanges();
            return RedirectToAction("List", "Incident");


        }
    }
}