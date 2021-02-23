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
            return View(incident);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // TO DO
            ViewBag.Action = "Add";
            ViewBag.Incident = context.Incident.OrderBy(c => c.incidentTitle.ToList());
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
        public IActionResult Edit(Incident incident)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            context.Incident.Remove(incident); // remove 
            context.SaveChanges();
            return RedirectToAction("Index", "Home");


        }
    }
}