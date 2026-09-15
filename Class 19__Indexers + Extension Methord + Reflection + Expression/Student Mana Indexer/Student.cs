using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Mana_Indexer
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double CGPA { get; set; }

        public Student(int id, string name, string department, double cgpa)
        {
            Id = id;
            Name = name;
            Department = department;
            CGPA = cgpa;
        }
    }
}
