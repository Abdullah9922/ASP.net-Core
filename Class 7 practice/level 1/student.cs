using System;
using System.Collections.Generic;
using System.Text;

namespace level_1
{
    public class Student
    {
        private string _name;
        private int _age;
        private readonly int _id;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != string.Empty) { _name = value; }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if(value >= 18 &&  value <= 30) _age = value;
            }
        }

        public Student() : this("Unknown")
        {

        }

        public Student(string name) : this(name, 18)
        {
            _name = name;
        }

        public Student(string name, int age) : this(name, age, 0000)
        {
            _name= name;
            _age = age;
        }

        public Student(string name,int age,int id)
        {
            _name = name;
            _age = age;
            _id = id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age  : {Age}");
            Console.WriteLine($"ID   : {_id}");
        }

        public void Study() => Console.WriteLine($"{Name} is studeing");

        public void Study(int hours) => Console.WriteLine($"{Name} is studying for {hours} hours.");

        public void Study(string subject) => Console.WriteLine($"{Name} is studying {subject}.");

        public void Study(int hours, string subject) => Console.WriteLine($"{Name} is studying {subject} for {hours} hours.");




    }
}
