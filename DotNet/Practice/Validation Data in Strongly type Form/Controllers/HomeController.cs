using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Validation_Data_in_Strongly_type_Form.Models;

namespace Validation_Data_in_Strongly_type_Form.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student s)
        {
            if (ModelState.IsValid)
            {
                // strudent data store korbe ba ame caile age moto oita show korateo pari 
                return RedirectToAction("ShowData", s);
            }
            return View(s);
        }

        public IActionResult ShowData(Student s)
        {
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
