using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExampleRepeat
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Cgpa { get; set; }
        public List<CourseRegistration> CourseRegistrations { get; set; } = new List<CourseRegistration>();

    }
}
