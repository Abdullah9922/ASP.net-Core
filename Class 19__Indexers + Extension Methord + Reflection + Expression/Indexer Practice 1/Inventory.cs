using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer_Practice_1
{
    public class Inventory 
    {

        private Product[] products;

        public Inventory(Product[] products)
        {
            this.products = products;
        }

        public Product this[int index]
        {
            get
            {
                return products[index];
            }

            set
            {
                products[index] = value;
            }
        }
    }
}
