using Microsoft.AspNetCore.Mvc;
using Course_Enrollment_Management__Practice_.Models;

namespace Course_Enrollment_Management__Practice_.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger; 

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

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
            _logger.LogInformation("Student data send to Index");
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
                _logger.LogInformation($"-------------Student {s.Id} add to list---------");
                Students.Add(s);
                return RedirectToAction("Details",s);
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

        [HttpPost]
        public IActionResult Edit(Student s)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation($"-------------Student {s.Id} Edited to list---------");
                Students.Add(s);
                return RedirectToAction("Details", s);
            }
            return View(s);
        }

        // GET
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                _logger.LogInformation($"-------------Student {student.Name} not found to list---------");
                return NotFound();
            }
               

            return View(student);
        }

        // POST
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                _logger.LogInformation($"-------------Student {student.Name} not found to list---------");
                return NotFound();
            }
                

            Students.Remove(student);
            _logger.LogInformation($"-------------Student {student.Name} removed to list---------");

            return RedirectToAction(nameof(Index));
        }
    }
}
