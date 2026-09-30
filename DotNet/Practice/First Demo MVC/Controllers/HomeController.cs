using First_Demo_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_Demo_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["Message"] = "This is a massage from Index Action Methord.";
            Student s = new Student()
            {
                Id = 1,
                Name = "Test",
                Cgpa = 3.4
            };
            //return RedirectToAction("Gallary");
            return View(s);
        }

        public IActionResult ContractUs()
        {
            ViewData["PId"] = 001;
            ViewData["PName"] = "Laptop";
            ViewData["Price"] = 340000.5;
            ViewData["Quantity"] = 5;
            return View();
        }

        public IActionResult Gallary()
        {
            
            ViewBag.Roll = 918;
            ViewBag.Name = "Asif";
            ViewBag.Cgpa = 3.5;
            ViewBag.Num1 = 3;
            ViewBag.Num2 = 4;
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
