using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Box__Practice_
{
    public class Box<T>
    {
        private T _value;
        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Box(T value)
        {
            _value = value;
        }

        public void Print()
        {
            Console.WriteLine("Value : " + Value);
        }

        public void GenericPrint<E>(E value)
        {
            Console.WriteLine("Generic Value: " +  value);
        }
    }
}
