using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Object_Creation__Reflection_Practice_
{
    public  class Product
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }

        public Product()
        {
        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
