using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    public struct Student
    {
        public int Id { get; }
        public string Name { get; }
        public double CGPA { get; }

        public Student(int id, string name, double cgpa)
        {
            Id = id;
            Name = name;
            CGPA = cgpa;
        }

        public bool IsPassed()
        {
            return CGPA >= 2.00;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CGPA: {CGPA}");
            Console.WriteLine($"Passed: {IsPassed()}");
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {CGPA}";
        }
    }
}
