using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using DemoMVC.Models.ViewModels;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
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

        [HttpGet]
        public IActionResult StudentBare()
        {
            var model = new Student
            {
                FirstName = "Johan",
                LastName = "Smarius",
                Number = 12345,
                StartYear = 2018
            };
            
            return View("StudentBare", model);
        }

        [HttpGet]
        public IActionResult Teacher()
        {
            var teacher = new Teacher
            {
                Name = "John Doe",
                Code = "C#"
            };

            return View("Teacher", teacher);
        }



    }
}
