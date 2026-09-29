using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generics
{
    public class ShoppingCart2<T, Q>
    where T : class, IProduct2<Q>, new() // এখানে IProduct2<Q>-তে Q দেওয়ার কারণ হলো T-এর Price কোন type-এর হবে সেটা নির্ধারণ করা।
    where Q : struct, INumber<Q> // T = Product type, Q = Price type


        /*
         T অবশ্যই এমন একটি class হবে, যেটা
        IProduct<Q> implement করে এবং যার
        parameterless constructor আছে। 
        আর Q অবশ্যই একটি numeric struct/value type হবে।
         */
    {
        private readonly T[] _items;

        public ShoppingCart2(T[] items)
        {
            _items = items;
        }

        public Q GetTotal()
        {
            var total = default(Q);
            foreach (var item in _items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
