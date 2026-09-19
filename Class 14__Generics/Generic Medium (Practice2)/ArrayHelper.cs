using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generic_Medium__Practice2_
{
    public class ArrayHelper<T> where T : INumber<T>
    {
        public void Print(T[] array)
        {
            Console.WriteLine();
            for(int i=0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public T GetFirst(T[] array)
        {
            return array[0];
        }

        public T GetLast(T[] array)
        {
            return array[array.Length-1];
        }

        public int GetCount(T[] array,T item)
        {
            int count = 0;
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] == item) count++;
            }
            return count;
        }
    }
}
