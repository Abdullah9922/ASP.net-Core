using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Product_Repository__Practice2_
{
    public class Repository<T,TId> where T : IEntity<TId>
    {
        private List<T> _products = new();

        public void Add(T item)
        {
            _products.Add(item);
        }

        public void Remove(T item)
        {
            _products.Remove(item);
        }

        public List<T> GetAll()
        {
            return _products;
        }

        public T? GetById(TId id)
        {
            return _products.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
