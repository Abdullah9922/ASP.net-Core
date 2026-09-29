using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Management_System
{
    public abstract class Vehicle
    {
        const double Tax = 0.15;

        private string _brand;

        private string _model;

        private int _year;

        private double _basePrice;

        public string Brand
        {
            get { return _brand; }
            set { if(value != string.Empty) _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { if (value != string.Empty) _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { if(value >= 1800 && value <= 2026) _year = value; }
        }

        public double BasePrice
        {
            get { return _basePrice; }
            set { if (value > 0 ) _basePrice = value; }
        }

        public bool IsAvailable { get; set; }

        public Vehicle() : this("Unknown", "Unknown", 1800, 1.00, true) { }
        public Vehicle(string brand, string model, int year, double basePrice, bool isAvailable)
        {
            Brand = brand;
            Model = model;
            Year = year;
            BasePrice = basePrice;
            IsAvailable = isAvailable;
        }

        public abstract void ShowDetails();
        public virtual void Honk() { }
        public virtual void DisplayEngine() { }
        public void PrintTax()
        {
            Console.WriteLine("Tax: " + Tax);
        }
    }
}
