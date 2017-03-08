﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PrepDay4.Controllers
{
    public class CheeseController : Controller
    {
        static private List<string> Cheeses = new List<string>();

        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name)
        {
            // Add the new cheese to my existing 
            Cheeses.Add(name);

            return Redirect("/Cheese");

        }
    }
}
