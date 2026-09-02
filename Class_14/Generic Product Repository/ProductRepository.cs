using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generic_Product_Repository
{
    public class ProductRepository<T, TId>
        where T : class, IProduct<TId>, new()
        where TId: INumber<TId>

        /*
           T   → কোন ধরনের object?
           TId → সেই object-এর ID কোন type?
         */
    {
        private readonly List<T> _container = new();

        public void Add(T product)
        {
            _container.Add(product);
        }

        public T? GetById(TId id)
        {
            return _container.Find(x => x.Id == id);
        }

        public void Remove(TId id)
        {
            T? item = _container.Find(x => x.Id == id);

            if (item != null)
            {
                _container.Remove(item);
            }
        }

        public List<T> GetAll()
        {
            return _container.ToList();
        }

        public T? GetMostExpensive()
        {
            return _container.MaxBy(x => x.Price);
        }
    }
}
