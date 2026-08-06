using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Management_System
{
    public class Tesla : Car
    {
        public Tesla(int seats, string brand, string model, int year, double basePrice, bool isAvailable)
            : base(seats,brand, model, year, basePrice, isAvailable)
        {
        }

        public override void DisplayEngine()
        {
            Console.WriteLine("Electric Motor");
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Brand      : " + Brand);
            Console.WriteLine("Model      : " + Model);
            Console.WriteLine("Year       : " + Year);
            Console.WriteLine("BasePrice  : " + BasePrice);
            Console.WriteLine("Available  : " + IsAvailable);
            Console.WriteLine();
        }

    }
}
