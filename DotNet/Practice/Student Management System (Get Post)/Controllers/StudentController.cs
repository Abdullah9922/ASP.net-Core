using Microsoft.AspNetCore.Mvc;
using Student_Management_System__Get_Post_.Models;

namespace Student_Management_System__Get_Post_.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewStudent(Student s)
        {
            Student.students.Add(s);
            return RedirectToAction("ShowNewStudent");
        }

        public IActionResult ShowNewStudent()
        {
            var student = Student.students.Last();

            return View(student);
        }

        public IActionResult ShowAllStudent()
        {
            var students = Student.students;
            return View(students);
        }
    }
}
