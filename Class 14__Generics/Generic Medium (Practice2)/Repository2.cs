using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Generic_Medium__Practice2_
{
    public class Repository2<T, TId> where T : IEntity<TId>
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

        public T GetById(TId id)
        {
            T? item = lists.FirstOrDefault(x => x.Id.Equals(id));
            return item;
        }
    }
}
