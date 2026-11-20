using Microsoft.AspNetCore.Mvc;
using Infrastructure.Models;
using System.Diagnostics;
using Cortex.Mediator;
using Domain.Entities;
using Application.Features.BookManagement.Commands;
using Application.Features.BookManagement.Queries;

namespace Infrastructure.Controllers
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
            Book book = new Book() { Price = 500, Title = "DSA"};
            BookAddCommand bookAddCommand = new BookAddCommand() { Book = book};

            var result = await _mediator.SendCommandAsync(bookAddCommand);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Get()
        {
            Guid id = new Guid("48e29bad-9c22-4ad4-a95c-3a13d618541a");
            GetBookByIdQuery query = new GetBookByIdQuery();

            query.Id = id;
            var result = await _mediator.SendCommandAsync(query);
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
