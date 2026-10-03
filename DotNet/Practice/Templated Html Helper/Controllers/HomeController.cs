using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Templated_Html_Helper.Models;

namespace Templated_Html_Helper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student()
            {
                Id = 918,
                Name = "Asif",
                DateOfBirth = new DateTime(2002, 10, 10),
                IsDisable = false
            };
            return View(s);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
