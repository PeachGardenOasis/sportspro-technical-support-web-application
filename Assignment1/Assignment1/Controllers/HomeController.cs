﻿using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private IncidentContext context { get; set; }

        public HomeController(IncidentContext ctx)
        {
            context = ctx;
        }
         
        public IActionResult Index()
        {
            return View();
        }
    }
}
