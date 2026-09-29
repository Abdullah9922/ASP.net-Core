using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Management_System
{
    public class Car : Vehicle, IStartable, IRentable
    {
        private int _seats;

        public int Seats 
        {  
            get { return _seats; }
            set { if(value >= 2)  _seats = value; }
        }

        public Car(int seats, string brand, string model, int year, double basePrice, bool isAvailable) 
            : base(brand,model,year,basePrice,isAvailable)
        {
            Seats = seats;
        }


        public void Start()
        {
            Console.WriteLine("Car is Start.");
        }

        public void Stop()
        {
            Console.WriteLine("Car is Start.");
        }

        public double CalculateRent(int days)
        {
            return 1.5;
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

        public override void Honk() 
        {
            Console.WriteLine("Car Honk");
        }

        public override void DisplayEngine() 
        {
            Console.WriteLine("Unknown Engine");
        }
    }
}
