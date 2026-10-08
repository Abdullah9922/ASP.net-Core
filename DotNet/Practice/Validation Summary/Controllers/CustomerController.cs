using Microsoft.AspNetCore.Mvc;
using Validation_Summary.Models;

namespace Validation_Summary.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer c)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ShowNewCustomer", c);
            }
            return View(c);
        }

        public IActionResult ShowNewCustomer(Customer c)
        {
            return View(c);
        }
    }
}
