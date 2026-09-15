using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_Overloading
{
    public class Complex
    {
        public int Real;
        public int Imaginary;

        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex( a.Real + b.Real, a.Imaginary + b.Imaginary);
        }
    }
}
