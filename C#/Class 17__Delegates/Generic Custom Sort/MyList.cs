using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Custom_Sort
{
    public class MyList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }


        // Delegate parameter
        public void Sort(Func<T, T, bool> c)
        {
            for (int i = 0; i < items.Count - 1; i++)
            {
                for (int j = 0; j < items.Count - i - 1; j++)
                {
                    // Delegate call
                    if (c(items[j], items[j + 1]))
                    {
                        T temp = items[j];

                        items[j] = items[j + 1];

                        items[j + 1] = temp;
                    }
                }
            }
        }


        public void Print()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
