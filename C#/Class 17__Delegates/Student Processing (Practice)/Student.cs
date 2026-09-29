using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Processing__Practice_
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"{Name} -> {Marks}";
        }
    }
}
