using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Generics__Easy_
{
    public class GenericBox<T>
    {
        private T _value;

        public GenericBox(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }

        public void SetValue(T value)
        {
            _value=value;
        }

        public void Display()
        {
            Console.WriteLine("Value is: " +  _value);
        }
    }
}
