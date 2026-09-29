using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Sorting__Practice_2_
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }

        public Student(int id, string name, double cgpa)
        {
            Id = id;
            Name = name;
            CGPA = cgpa;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - CGPA: {CGPA}";
        }
    }
}
