using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers_Example
{
    public class ShoppingCart
    {
        private string[] products = new string[5];

        public string this[int index]
        {
            get => products[index];
            set => products[index] = value;
        }
    }
}
