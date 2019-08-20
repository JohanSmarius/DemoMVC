using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
