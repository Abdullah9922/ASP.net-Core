using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Product_Repository
{
    class Product : IProduct<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
