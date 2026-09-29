using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Generics
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item) => items.Add(item);
        public void Delete(T item) => items.Remove(item);
        public T Get(int id) => items[id];
        public List<T> GetAll() => items;
    }
}
