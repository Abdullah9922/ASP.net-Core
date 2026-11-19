using Application.DoctorManagement.Commands;
using Application.DoctorManagement.Quaries;
using Cortex.Mediator;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using System.Diagnostics;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

            public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Add()
        {
            Doctor d = new Doctor() { Name = "Test", Age = 35};
            DoctorAddCommand command = new DoctorAddCommand();
            command.Doctor = d;

            var result = await _mediator.SendCommandAsync(command);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Get()
        {
            Guid id = new Guid("50bf896e-0789-490e-ba10-14511287f691"); 
            GetDoctorByIdQuery query = new GetDoctorByIdQuery();
            query.Id = id;

            var doctor = await _mediator.SendCommandAsync(query);
            return RedirectToAction("Index");
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
