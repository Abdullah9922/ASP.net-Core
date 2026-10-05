using Microsoft.AspNetCore.Mvc;
using Scaffolding.Models;

namespace Scaffolding.Controllers
{
    public class StudentController : Controller
    {
        public List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 101,
                Name = "Asif",
                Department = "CSE",
                CGPA = 3.75,
                DateOfBirth = new DateTime(2003, 5, 15),
                IsActive = true,
                Grade = 'A',
                TuitionFee = 55000.50m
            },

            new Student()
            {
                Id = 102,
                Name = "Rahim",
                Department = "EEE",
                CGPA = 3.50,
                DateOfBirth = new DateTime(2002, 8, 20),
                IsActive = true,
                Grade = 'A',
                TuitionFee = 52000.00m
            },

            new Student()
            {
                Id = 103,
                Name = "Karim",
                Department = "CSE",
                CGPA = 3.20,
                DateOfBirth = new DateTime(2003, 1, 10),
                IsActive = true,
                Grade = 'B',
                TuitionFee = 50000.75m
            },

            new Student()
            {
                Id = 104,
                Name = "Hasan",
                Department = "BBA",
                CGPA = 3.85,
                DateOfBirth = new DateTime(2002, 11, 5),
                IsActive = false,
                Grade = 'A',
                TuitionFee = 48000.00m
            },

            new Student()
            {
                Id = 105,
                Name = "Nayeem",
                Department = "CSE",
                CGPA = 3.40,
                DateOfBirth = new DateTime(2003, 7, 25),
                IsActive = true,
                Grade = 'B',
                TuitionFee = 53000.25m
            }
        };
        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var obj = students.FirstOrDefault(x => x.Id == id);
            return View(obj);
        }

        public IActionResult Details(int id)
        {
            var obj = students.FirstOrDefault(x => x.Id == id);
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            var obj = students.FirstOrDefault(x => x.Id == id);
            return View(obj);
        }
    }
}
