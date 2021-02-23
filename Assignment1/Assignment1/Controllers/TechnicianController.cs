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
            return View("Edit", new Technician()); // makes new form from Technician template
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Technician = context.Technician.OrderBy(c => c.technicianFullName.ToList());

          

            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            var technician = context.Technician;
            return View(technician);
        }

        [HttpPost]
        public IActionResult Edit(Technician technician)
        {
            string action = (technician.technicianId==0)?"Add":"Edit";

            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    
                }
            }
            else
            {
                ViewBag.Action = "Edit";
                ViewBag.Technician = context.Technician.OrderBy(c => c.technicianFullName.ToList());
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            context.Technician.Remove(technician); // remove technician
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}