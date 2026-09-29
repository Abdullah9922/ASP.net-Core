using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Salary_System__Practice_2_
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void Print()
        {
            Console.WriteLine( $"{Id} - {Name} - {Department} - Salary: {Salary}");
        }

    }
}
