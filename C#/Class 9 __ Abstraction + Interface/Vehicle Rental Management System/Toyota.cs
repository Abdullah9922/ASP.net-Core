using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Management_System
{
    public class Toyota : Car
    {
        private string _hybrid {  get; set; }

        public Toyota (string brand, string model, int year, double basePrice, bool isAvailable,int sit, string hybrid)
            : base(sit,brand, model, year, basePrice, isAvailable)
        {
            _hybrid = hybrid;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Brand      : " + Brand);
            Console.WriteLine("Model      : " + Model);
            Console.WriteLine("Year       : " + Year);
            Console.WriteLine("BasePrice  : " + BasePrice);
            Console.WriteLine("Available  : " + IsAvailable);
            Console.WriteLine("Hybrid     : " + _hybrid);
            Console.WriteLine();
        }

        public override void DisplayEngine()
        {
            Console.WriteLine("Toyota Hybrid Engine");
        }
    }
}
