using Demo.Application.Contracts;
using Demo.Domain.Entities;
using Demo.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public StudentController(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
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
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                // Insert student into database
                _applicationUnitOfWork.StudentRepositroy.Add(student);
                _applicationUnitOfWork.Save();

                return RedirectToAction("Index");
            }

            return View(student);
        }
    }
}
