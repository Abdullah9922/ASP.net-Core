using Cortex.Mediator;
using Demo.Application.Features.TeacherManagement.Commands;
using Demo.Application.Features.TeacherManagement.Queries;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IMediator _mediator;
        public TeacherController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddTeacher()
        {
            Teacher t = new Teacher() { Name = "Test" , Age = 32};
            TeacherAddCommand command = new TeacherAddCommand();
            command.Teacher = t;

            var result = await _mediator.SendCommandAsync(command);
            return Index();
        }

        public async Task<IActionResult> ShowTeacher()
        {
            Guid gid = new Guid("96036f98-2850-462c-818a-5ad0e191713b");
            GetTeacherByIdQurey qurey = new GetTeacherByIdQurey();
            qurey.Id = gid;
            var result = await _mediator.SendCommandAsync(qurey);
            return Index();
        }
    }
}
