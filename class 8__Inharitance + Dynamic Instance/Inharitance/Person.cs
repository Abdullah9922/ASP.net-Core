using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_University_Management_System
{
    public class Person
    {
        protected string _name;
        protected int _age;
        protected readonly int _id;

        const string UniversityName = "Daffodil International University";

        public string Name 
        { 
            get { return _name; } 
            set { if (_name != value) _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { if(value >= 18 && value <= 70) _age = value; }
        }

        public Person() : this("Unknown")
        {
        }

        public Person(string name): this(name, 0)
        {

        }

        public Person(string name,int age): this(name, age, 000)
        {

        }

        public Person(string name,int age,int id)
        {
            _name = name;
            _age = age;
            _id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age  : {Age}");
            Console.WriteLine($"Id   : {_id}");
        }

        public virtual void Work()
        {

        }
        public virtual void Study()
        {
            Console.WriteLine("Person do study or not.");
        }

        //public virtual double CalculateSalary()
        //{
        //    return _age; 
        //}
    }
}
