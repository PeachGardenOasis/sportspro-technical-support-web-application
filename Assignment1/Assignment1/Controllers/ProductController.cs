﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Edit(Product product)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            return View();
        }
    }
}
