﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello World";
        //}

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult TimeView()
        {
            ViewBag.CurrentTime = DateTime.Now.ToLongTimeString();
            return View("DemoView");
        }

        [HttpGet]
        public IActionResult StudentEdit()
        {
            var model = new Student
            {
                FirstName = "Johan",
                LastName = "Smarius",
                Number = 12345,
                StartYear = 2018
            };

            return View("StudentEdit", model);
        }

        [HttpPost]
        public IActionResult StudentEdit(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }


            return View();
        }

    }
}
