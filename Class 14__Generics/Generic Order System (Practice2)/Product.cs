using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Generic_Order_System__Practice2_
{
    public class Product<TId> : IProduct<TId>
    {
        public TId Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(TId id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"ID    : {Id}");
            Console.WriteLine($"Name  : {Name}");
            Console.WriteLine($"Price : {Price}");
        }
    }
}
