using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Custom_Sort
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public Student(string name, int age, int marks)
        {
            Name = name;
            Age = age;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"{Name,-10} Age: {Age,-3} Marks: {Marks}";
        }
    }
}
