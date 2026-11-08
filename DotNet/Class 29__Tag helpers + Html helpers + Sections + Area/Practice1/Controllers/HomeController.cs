using Practice1.Code;
using Microsoft.AspNetCore.Mvc;
using Practice1.Models;
using System.Diagnostics;


namespace Practice1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger<HomeController> _logger;
        public HomeController(IEmailSender emailSender, ILogger<HomeController> logger  )
        {
            _emailSender = emailSender;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                _emailSender.SendMail("abc@gmain.com", "Hi everyone");
                _logger.LogInformation("Log is writing");
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while sending email.");
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
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
