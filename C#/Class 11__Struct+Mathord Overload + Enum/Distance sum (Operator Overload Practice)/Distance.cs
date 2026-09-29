using System;
using System.Collections.Generic;
using System.Text;

namespace Distance_sum__Operator_Overload_Practice_
{
    public struct Distance
    {
        public int Feet { get; set; }
        public int Inch { get; set; }

        public Distance(int feet, int inch)
        {
            Feet = feet;
            Inch = inch;
        }

        public static Distance operator +(Distance a , Distance b)
        {
            int totalFeet = a.Feet + b.Feet;
            int totalInch = a.Inch + b.Inch;
            if(totalInch >= 12)
            {
                totalFeet += totalInch / 12;
                totalInch = totalInch % 12;
            }

            return new Distance(totalFeet, totalInch);
        }

        public void Display()
        {
            Console.WriteLine($"{Feet} feet {Inch} inch");
        }
    }
}
