using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Filter_System
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{Name} | Price: {Price} | Stock: {Stock}";
        }
    }
}
