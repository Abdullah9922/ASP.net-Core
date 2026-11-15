using Demo.Application.Contracts;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IApplicationUintOfWork _applicationUintOfWork;

        public StudentController(IApplicationUintOfWork applicationUintOfWork)
        {
            _applicationUintOfWork = applicationUintOfWork;
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
                _applicationUintOfWork.StudentRepository.Add(student);
                _applicationUintOfWork.Save();

                return RedirectToAction("Index");
            }

            return View(student);
        }
    }
}
