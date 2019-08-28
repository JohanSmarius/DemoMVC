using System;
using System.Collections.Generic;
using System.Text;
using DemoMVC.Models.ViewModels;

namespace DemoMVC.Models
{
    public class Course
    {
        public List<Student> Students { get; set; }

        public Teacher Teacher { get; set; }

        public string Name { get; set; }
    }
}
