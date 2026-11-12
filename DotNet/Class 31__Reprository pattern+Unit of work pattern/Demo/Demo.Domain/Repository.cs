using System;
using System.Collections.Generic;
using System.Text;
using Demo.Domain.Entities;

namespace Demo.Domain
{
    public class Repository<T>
    {
        public void Add(T product)
        {
            // Implementation for adding a product to the repository
        }

        public void Remove(T product)
        {
            // Implementation for removing a product from the repository
        }

        public void Update(T product)
        {
            // Implementation for updating a product in the repository
        }

        public void GetById(int productId)
        {
            // Implementation for retrieving a product by its ID from the repository
        }
    }
}
