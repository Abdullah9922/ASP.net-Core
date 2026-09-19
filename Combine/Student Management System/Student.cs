using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace Student_Management_System
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public Gender Gender { get; set; }
        public double CGPA { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public long? PhoneNumber { get; set; }

        public static bool operator >(Student s1, Student s2)
        {
            return s1.CGPA > s2.CGPA;
        }
        public static bool operator <(Student s1, Student s2)
        {
            return s1.CGPA < s2.CGPA;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Id == s2.Id;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return s1.Id != s2.Id;
        }

        public int GetAge(Student s)
        {
            DateTime now = DateTime.Now;

            int age;
            if (now.Month <= DateOfBirth.Month && now.Day <= DateOfBirth.Day)
            {
                age = now.Year - DateOfBirth.Year;
            }
            else
            {
                age = now.Year - DateOfBirth.Year;
                age--;
            }
            return age;
        }

        public (String Name, double CGPA, Department dep, int age) GetStudentSummary(Student s)
        {
            DateTime now = DateTime.Now;
            return (s.Name,s.CGPA,s.Department,GetAge(s));
        }
    }
}
