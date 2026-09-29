using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Information_System__Practice3_
{
    public struct  Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double Cgpa { get; set; }

        public (string Name, double Cgpa) Print()
        {
            Console.WriteLine($"Id {Id}, Name {Name} , BirthDate {BirthDate}, CGPA {Cgpa}");
            return (Name, Cgpa);
        }

    }
}
