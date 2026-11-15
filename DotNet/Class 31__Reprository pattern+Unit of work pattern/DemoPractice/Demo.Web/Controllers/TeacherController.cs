using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
