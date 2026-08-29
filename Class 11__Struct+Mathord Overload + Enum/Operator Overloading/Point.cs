using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_Overloading
{
    public class Point
    {
        public int X;
        public int Y;

        public static Point operator +(Point p1, Point p2)
        {
            return new Point
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }
    }
}
