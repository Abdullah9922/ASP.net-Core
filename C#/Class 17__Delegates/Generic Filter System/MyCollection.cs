using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Filter_System
{
    public class MyCollection<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        // Delegate as parameter
        public List<T> Filter(Func<T, bool> condition)
        {
            List<T> result = new List<T>();

            foreach (T item in items)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
