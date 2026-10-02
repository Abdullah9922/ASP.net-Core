using Microsoft.AspNetCore.Mvc;
using Student_Management_System.Models;

namespace Student_Management_System.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllStudent()
        {
            var students = Student.Students;
            return View(students);
        }

        public IActionResult AddStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult NewStudent(Student s)
        {
            Student.Students.Add(s);
            return View(s);
        }

        [HttpPost]
        public IActionResult SearchById(int id)
        {
            var students = Student.Students;
            Student? temp = students.FirstOrDefault(x => x.Id == id);

            return View(temp);
        }

        public IActionResult InputStudentId()
        {
            return View();
        }

    }
}
