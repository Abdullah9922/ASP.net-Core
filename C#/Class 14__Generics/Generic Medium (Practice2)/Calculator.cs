using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generic_Medium__Practice2_
{
    public class Calculator<T> where T: INumber<T>
    {
        public static void Add (T t1, T t2)
        {
            Console.WriteLine( t1 + t2);
        }

        public static T Subtract(T t1, T t2)
        {
            return t1 - t2;
        }

        public static void Multiply(T t1, T t2)
        {
            Console.WriteLine(t1 * t2);
        }
    }
}
