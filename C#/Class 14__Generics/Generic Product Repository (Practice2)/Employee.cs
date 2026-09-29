using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Product_Repository__Practice2_
{
    public class Employee : IEntity<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(string id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}
