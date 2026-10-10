using Dependency_Injection.Models;
using Dependency_Injection.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        // Constructor Injection
        /*private readonly IGreeting Greeting;
        
        public HomeController(IGreeting g)
        {
            this.Greeting = g;
        }*/

        // Property injection 
        /*[FromServices]
        public IGreeting Greeting { get; set; }*/

        
         // Methord Injection
        public IActionResult Index([FromServices] IGreeting Greeting)
        {
            ViewData["Message"] = Greeting.GetGreeting();
            return View();
        }

        // not necessary to add Dependency injection in Controller only, we can use it inside view also
        public IActionResult ShowGreeting()
        {
            return View();
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
