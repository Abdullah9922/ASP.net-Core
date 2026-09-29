using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Smart_University_Management_System
{
    public class Student : Person
    {
        private string Department { get; set; }
        private double _cgpa;
        private double _creditCompleted;
        

        public double Cgpa
        {
            get { return _cgpa; }
            set { if(value >= 0.00 && value <= 4.00) _cgpa = value; }
        }

        public double CgpaCompleted
        {
            get { return _creditCompleted; }
            set { if(value >= 0 &&  value <= 180) _creditCompleted = value; }
        }

        public Student(): this("Unknown")
        {

        }

        public Student(string department): this(department, 0.00)
        {

        }

        public Student (string department, double cgpa): this(department, cgpa, 0.00)
        {

        }

        public Student(string department,double cgpa,double credit) : base()
        {
            Department = department;
            _cgpa = cgpa;
            _creditCompleted = credit;
        }

        public Student(string name,string department, double cgpa, double credit) : base(name)
        {
            Department = department;
            _cgpa = cgpa;
            _creditCompleted = credit;
        }

        public Student(string name,int age,int id, string department, double cgpa, double credit) : base(name,age,id)
        {
            Department = department;
            _cgpa = cgpa;
            _creditCompleted = credit;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Department         : {Department}");
            Console.WriteLine($"cgpa               : {_cgpa}");
            Console.WriteLine($"credit Completed   : {_creditCompleted}");
        }

        public override void Study()
        {
            Console.WriteLine("Student need to Sudy.");
        }

        public void TakeExam()
        {

        }

        public void RegisterCourse()
        {

        }

    }
}
