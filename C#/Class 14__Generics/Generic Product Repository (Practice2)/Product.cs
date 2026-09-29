using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Generic_Product_Repository__Practice2_
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
    }
}
