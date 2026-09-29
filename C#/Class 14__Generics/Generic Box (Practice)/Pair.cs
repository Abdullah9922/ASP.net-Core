using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Box__Practice_
{
    public class Pair<X,Y>
    {
        public X First { get; set; }
        public Y Second { get; set; }

        public Pair(X first, Y second)
        {
            First = first;
            Second = second;
        }

        public void Print()
        {
            Console.WriteLine("Pair Values: " + First + ", " + Second);
        }
    }
}
