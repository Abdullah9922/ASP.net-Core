using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class ShopingCart<T> where T : IProduct
    {
        private readonly T[] _items;

        public ShopingCart(T[] items)
        {
            _items = items;
        }

        public int GetTotal()
        {
            var total = 0;
            foreach (var item in _items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
