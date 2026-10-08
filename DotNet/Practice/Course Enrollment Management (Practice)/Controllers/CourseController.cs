using Microsoft.AspNetCore.Mvc;

namespace Course_Enrollment_Management__Practice_.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
