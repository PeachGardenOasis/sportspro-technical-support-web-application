using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class TechnicianController : Controller
    {
        private IncidentContext context { get; set; }

        public TechnicianController(IncidentContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            var technican = context.Technician;
            return View(technican);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // TO DO
            ViewBag.Action = "Add";
            ViewBag.Technician = context.Technician.OrderBy(c => c.technicianFullName.ToList());
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