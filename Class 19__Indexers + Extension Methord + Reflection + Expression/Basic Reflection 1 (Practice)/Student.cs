using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Reflection_1__Practice_
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private double Cgpa { get; set; }

        public void Study()
        {
            Console.WriteLine("Student is studying");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}");
        }
    }
}
