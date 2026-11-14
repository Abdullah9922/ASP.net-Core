using Demo.Application.Contracts;
using Demo.Domain.Entities;
using Demo.Web.Code;
using Demo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger<HomeController> _logger;
        private readonly IApplicationUnitOfWork _applicationUintOfWork;

        public HomeController(IEmailSender emailSender, ILogger<HomeController> logger, IApplicationUnitOfWork applicationUnitOfWork)

        {
            _applicationUintOfWork = applicationUnitOfWork;
            _emailSender = emailSender;
            _logger = logger;
        }

        public IActionResult Test()
        {
            Product product = new Product { Id = Guid.NewGuid(), Name = "Test Product 1", Price = 2099 };
            _applicationUintOfWork.Products.Add(product);
            _applicationUintOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            try
            {
                var model = new IndexModel
                {
                    WelcomeFrom = "Asp.net B14"
                };

                _logger.LogInformation("Sending test email");

                _emailSender.SendEmail("jalaluddin@devskill.com", "Welecome to Asp.net B14", "This is a test email from Asp.net B14");

                return View(model);
            }
            catch(Exception ex)
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
