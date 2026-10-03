using Microsoft.AspNetCore.Mvc;
using Strongly_Type_HTML_Helper.Models;

namespace Strongly_Type_HTML_Helper.Controllers
{
    public class loginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (login.Username == "admin" &&
                login.Password == "1234")
            {
                return Content("Login Successful");
            }

            return Content("Invalid Username or Password");
        }
    }
}
