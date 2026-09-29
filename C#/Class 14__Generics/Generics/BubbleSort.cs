using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generics
{
    public class BubbleSort<T> where T : INumber<T> 
    {
        /* where T : INumber<T> এখানে ব্যবহার করার মূল কারণ
         * হলো T-কে number type হিসেবে নিশ্চিত করা, যাতে 
         * তুমি > operator ব্যবহার করতে পারো।
         */

        public static T[] Sort(T[] arr)
        {
            T temp;
            bool swapped;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }

            return arr;
        }
    }
}
