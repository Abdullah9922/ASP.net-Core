using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Management_System
{
    public class ToyotaSupra : Toyota
    {
        public ToyotaSupra(string brand, string model, int year, double basePrice, bool isAvailable, int sit, string hybrid) 
            : base(brand, model, year, basePrice, isAvailable, sit, hybrid)
        {
        }

        public override void Honk()
        {
            Console.WriteLine("Supra Honk");
        }

        public override void DisplayEngine()
        {
            Console.WriteLine("Twin Turbo Engine");
        }
    }
}
