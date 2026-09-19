using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Medium__Practice2_
{
    public class Repository<T>
    {
        public List<T> lists = new();

        public void Add(T item)
        {
            lists.Add(item);
        }

        public void Remove(T item)
        {
            lists.Remove(item);
        }

        public List<T> GetAll()
        {
            return lists;
        }
    }
}
