using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Models;

namespace DemoMVC
{
    public class StudentRepository
    {
        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    FirstName = "Bill",
                    LastName = "Gates",
                    Number = 12345,
                    StartYear = 2018
                },
                new Student()
                {
                    FirstName = "Paul",
                    LastName = "Allen",
                    Number = 12346,
                    StartYear = 2017
                },
                new Student()
                {
                    FirstName = "Steve",
                    LastName = "Jobs",
                    Number = 100,
                    StartYear = 2016
                },
            };
        }
    }
}
