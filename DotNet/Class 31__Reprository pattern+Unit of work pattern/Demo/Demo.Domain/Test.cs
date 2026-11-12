using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain
{
    internal class Test
    {
        public void Demo()
        {
            Product p1 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 1",
                Price = 10.99m
            };

            List<Product> products = new List<Product>();
            products.Add(p1);

            Repository<Product> productRepository = new Repository<Product>();
            productRepository.Add(p1);
        }
    }
}
