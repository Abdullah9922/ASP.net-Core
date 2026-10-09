using Microsoft.AspNetCore.Mvc;

namespace Empty_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
