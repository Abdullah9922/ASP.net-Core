using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generics
{
    public class BubbleSort2<T> where T : INumber<T>
    {
        public T[] Numbers { get; private set; }

        public BubbleSort2(T[] arr)
        {
            Numbers = arr;
        }

        public void Sort()
        {
            T temp;
            bool swapped;
            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < Numbers.Length - i - 1; j++)
                {
                    if (Numbers[j] > Numbers[j + 1])
                    {
                        temp = Numbers[j];
                        Numbers[j] = Numbers[j + 1];
                        Numbers[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
        }
    }
}
