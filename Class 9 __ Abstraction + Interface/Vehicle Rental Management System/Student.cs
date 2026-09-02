using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Management_System
{
    public class Student : IStudent
    {
        // Name → only get required by interface
        public string Name { get; } = "Asif";

        // Age → interface-এ only set আছে
        public int Age
        {
            set
            {
                Console.WriteLine($"Age set to: {value}");
            }
        }

        // Department → get + set দুটোই required
        public string Department { get; set; }
    }
}
