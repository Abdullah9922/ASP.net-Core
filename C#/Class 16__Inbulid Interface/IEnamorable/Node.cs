using System;
using System.Collections.Generic;
using System.Text;

namespace IEnamorable
{
    public class Node<T>
    {
        public T Value;
        public T? Left;
        public T? Right;

        public Node(T value)
        {
            Value = value;
        }
    }
}
