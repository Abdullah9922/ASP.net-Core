using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Claculator__Medium_
{
    public class Calculator<T> where T: INumber<T>
    {

        public  T Add(T a, T b)
        {
            return a + b;
        }

        public  T Subtract(T a, T b)
        {
            return a - b;
        }

        public  T Multiply(T a, T b)
        {
            return a * b;
        }

        public  T Divide(T a, T b)
        {
            return a / b;
        }

        public  T Max(T a, T b)
        {
            return a > b ? a : b;
        }

        public  T Min(T a, T b)
        {
            return a < b ? a : b;
        }
    }
}
