using Cortex.Mediator;
using Demo.Application.Contracts;
using Demo.Application.Features.StudentManagement.Commands;
using Demo.Application.Features.StudentManagement.Queries;
using Demo.Domain.Entities;
using Demo.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Demo.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentAddCommand command = new StudentAddCommand();
                command.Student = student;
                // Insert student into database
                var result = await _mediator.SendCommandAsync(command);

                return RedirectToAction("Index");
            }

            return View(student);
        }

        public async Task<IActionResult> GetStudentById()
        {
            Guid guid = new Guid("ff78452f-c95f-4dc0-837c-17d42f510d88");
            GetStudentByIdQurey qurey = new GetStudentByIdQurey() { Id = guid };

            var Student = await _mediator.SendCommandAsync(qurey);

            return RedirectToAction("Index");
        }
    }
}
