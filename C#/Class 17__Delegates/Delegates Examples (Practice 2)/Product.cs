using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_Examples__Practice_2_
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void Print()
        {
            Console.WriteLine(
                $"Id: {Id}, Name: {Name}, Price: {Price}, Quantity: {Quantity}"
            );
        }
    }
}
