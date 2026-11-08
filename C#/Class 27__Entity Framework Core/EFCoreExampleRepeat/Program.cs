using EFCoreExampleRepeat;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

TrainingDbContext dbContext = new TrainingDbContext();


//dbContext.AddRange(new Student[]
//{
//    new Student { Name = "Asif", Age = 22, Cgpa = 3.75 },
//    new Student { Name = "Rahim", Age = 23, Cgpa = 3.50 },
//    new Student { Name = "Karim", Age = 21, Cgpa = 3.85 },
//    new Student { Name = "Sakib", Age = 24, Cgpa = 3.60 }
//});

//Student s1 = new Student()
//{
//    Name = "Asif",
//    Age = 24,
//    Cgpa = 3.56
//};
//dbContext.Students.Add(s1);


//dbContext.SaveChanges();



//var course1 = new Course
//{
//    Title = "Asp.net",
//    Fees = 40000,
//    IsActive = true,
//    TopicList = new List<Topic>
//    {
//        new Topic { Title = "Getting Started",  },
//        new Topic { Title = "Understand routing",  }
//    }
//};

//var course2 = new Course
//{
//    Title = "CI/CD",
//    Fees = 10000,
//    IsActive = true,
//    TopicList = new List<Topic>
//    {
//        new Topic { Title = "Getting Started",  },
//        new Topic { Title = "Understaning Deployment",  }
//    }
//};

//dbContext.Courses.Add(course1);
//dbContext.Courses.Add(course2);
//dbContext.SaveChanges();

#region Course Update

//var c1 = dbContext.Courses.Where(s => s.Id == 1)
//    .Include(x => x.TopicList)
//    .FirstOrDefault();

//foreach(var item  in c1.TopicList)
//{
//    Console.WriteLine(item.Title);
//}

#endregion



//var course3 = new Course
//{
//    Title = "C#",
//    Fees = 8000,
//    IsActive = true,

//    TopicList = new List<Topic> { new Topic { Title = "Tool installation" } },

//    CourseRegistrations = new List<CourseRegistration>
//    {
//        new CourseRegistration
//        {
//            Student = new Student{ Name = "tareq", Cgpa = 3, },
//            RegistationDate = DateTime.Now
//        },
//        new CourseRegistration
//        {
//            Student = new Student{ Name = "hasan", Cgpa = 2.5, },
//            RegistationDate = DateTime.Now.AddDays(-1)
//        }
//    }
//};
//dbContext.Courses.Add(course3);
//dbContext.SaveChanges();


//var courseForSuraiya = dbContext.Courses.FirstOrDefault(x => x.Title == "C#");
//var topicForSuraiya = dbContext.Courses.FirstOrDefault(x => x.TopicList.Any(y => y.Title == "Getting Started"));

//var topicForSuraiya = dbContext.Courses
//    .Where(x => x.TopicList.Any(y => y.Title == "Getting Started"))
//    .SelectMany(x => x.TopicList)
//    .FirstOrDefault(y => y.Title == "Getting Started");

//var student = new Student
//{
//    Name = "Suraiya",
//    Age = 21,
//    Cgpa = 4.00,
//    CourseRegistrations = new List<CourseRegistration>
//    {
//        new CourseRegistration { Course = courseForSuraiya},
//        new CourseRegistration
//        {
//            Course = new Course
//            {
//                Title = "Algorithm",
//                Fees = 5000,
//                IsActive = true,
//                TopicList = new List<Topic>
//                {
//                    topicForSuraiya,
//                    new Topic{ Title = "Dynamic Programming"},
//                    new Topic { Title = "Hashing"}
//                }
//            }
//        }
//    }
//};
//dbContext.Students.Add(student);
//dbContext.SaveChanges();


//var course = new Course
//{
//    Title = "Data Sturcture",
//    Fees = 6000,
//    IsActive = true,
//    TopicList = new List<Topic>
//    {
//        new Topic{ Title = "Introduction To DS" },
//        new Topic{ Title = "Stack & Queue"}
//    }
//};

//dbContext.Courses.Add(course);
//dbContext.SaveChanges();


//var course = dbContext.Courses.FirstOrDefault(s => s.Id == 6);
//dbContext.Courses.Remove(course);
//dbContext.SaveChanges();

var student = dbContext.Students
    .Include(x => x.CourseRegistrations)
    .FirstOrDefault(x => x.Id == 6); 
var course = dbContext.Courses.FirstOrDefault(x => x.Id == 5);


//if (student != null)
//{
//    var registrationToRemove = dbContext.Students.Where(x => x.Id == 7)
//        .Include(x => x.CourseRegistrations)
//        .FirstOrDefault();


//    if (registrationToRemove != null)
//    {
//        dbContext.Students.Remove(registrationToRemove);
//    }
//}

//student.CourseRegistrations ??= new List<CourseRegistration>();



student.CourseRegistrations = new List<CourseRegistration>()
{
    new CourseRegistration()
    {
        Course = course,
        RegistationDate = DateTime.Now
    }
};

dbContext.SaveChanges();