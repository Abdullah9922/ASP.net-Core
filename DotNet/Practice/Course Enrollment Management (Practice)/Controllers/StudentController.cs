using Microsoft.AspNetCore.Mvc;
using Course_Enrollment_Management__Practice_.Models;

namespace Course_Enrollment_Management__Practice_.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> Students = new List<Student>
        {
            new Student
            {
                Id = 101,
                Name = "Asif",
                Email = "asif@gmail.com",
                Department = "CSE",
                CGPA = 3.75
            },

            new Student
            {
                Id = 102,
                Name = "Rahim",
                Email = "rahim@gmail.com",
                Department = "CSE",
                CGPA = 3.50
            }
        };
        public IActionResult Index(Student s)
        {
            return View(Students);
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student s)
        {
            if (ModelState.IsValid)
            {
                Students.Add(s);
                return RedirectToAction("Details",s.Id);
            }
            return View(s);
        }

        public IActionResult Details(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);
            return View(student);
        }
    }
}
