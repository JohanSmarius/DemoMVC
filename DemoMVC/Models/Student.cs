using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Number { get; set; }

        public int StartYear { get; set; }
    }
}
