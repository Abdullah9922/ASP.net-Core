using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer_Practice_1
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(int  ProductId, string ProductName, double Price)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Price = Price;
        }

    }
}
