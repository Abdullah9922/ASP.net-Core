using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
