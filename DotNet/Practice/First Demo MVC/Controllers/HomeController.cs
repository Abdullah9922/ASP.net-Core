using First_Demo_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_Demo_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student()
            {
                Id = 1,
                Name = "Test",
                Cgpa = 3.4
            };
            return View(s);
        }

        public IActionResult ContractUs()
        {
            return View();
        }

        public IActionResult Gallary()
        {
            return View();
        }

        public IActionResult OurTeam()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ShowAllStudents()
        {
            List<Student> students = new List<Student>()
            { 
                new Student () {Id = 001, Name = "Korim",Cgpa = 3.65},
                new Student () {Id = 002, Name = "Rohim",Cgpa = 3.48},
                new Student () {Id = 003, Name = "Zoshim",Cgpa = 3.21}
            };
            return View(students);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
