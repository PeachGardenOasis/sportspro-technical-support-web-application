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
            var technican = context.Technician
                .OrderBy(c => c.technicianFullName).ToList();
            return View(technican);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // TO DO
            ViewBag.Action = "Add";
            ViewBag.Technician = context.Technician.OrderBy(c => c.technicianFullName.ToList());
            return View("Edit", new Technician()); // // forward to edit view page and an empty value contact page
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
                    context.Technician.Add(technician);

                }
                else
                {
                    context.Technician.Update(technician);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home"); // return home
            }
            else //if Model state is not valid
            {
                ViewBag.Action = action;
                ViewBag.Technician = context.Technician.OrderBy(c => c.technicianFullName.ToList());
            }
            return View(technician);
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