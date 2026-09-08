using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MyStack<T>
    {
        private T[] data;
        private int top = -1;

        public MyStack(int size)
        {
            data = new T[size];
        }

        public void Push(T item)
        {
            data[++top] = item; 
        }

        public T Pop()
        {
            return data[top--];
        }
    }
}
