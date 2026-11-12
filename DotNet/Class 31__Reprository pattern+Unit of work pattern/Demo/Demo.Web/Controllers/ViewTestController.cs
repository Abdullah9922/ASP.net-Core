using Microsoft.AspNetCore.Mvc;
using Demo.Web.Models;

namespace Demo.Web.Controllers
{
    public class ViewTestController : Controller
    {
        public IActionResult Index()
        {
            ViewTestIndexModel model = new ViewTestIndexModel();
            model.Username = "Jalaluddin";

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string Username, string Password)
        {
            return View();
        }
    }
}
