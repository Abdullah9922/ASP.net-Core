using Demo.Application.Contracts;
using Demo.Application.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IProductRepository Products { get; }
        public ICategoryRepository Categories { get; }
        public ISupplierRepository Suppliers { get; }
        public ICustomerRepository Customers { get; }

        public ApplicationUnitOfWork(ApplicationDbContext context, IProductRepository products, ICategoryRepository categories, ISupplierRepository suppliers,ICustomerRepository customers): base(context)
        {
            Products = products;
            Categories = categories;
            Suppliers = suppliers;
            Customers = customers;
        }
    }
}
