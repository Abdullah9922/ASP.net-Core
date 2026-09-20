using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_Examples__Practice_2_
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }
        public string Department { get; set; }

        public Student(int id, string name, double cgpa, string department)
        {
            Id = id;
            Name = name;
            CGPA = cgpa;
            Department = department;
        }

        public void Print2()
        {
            Console.WriteLine($"Id         : {Id}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"CGPA       : {CGPA}");
            Console.WriteLine($"Department : {Department}");
        }

        public void Print()
        {
            Console.WriteLine($"{Name} - {CGPA}");
        }
    }
}
