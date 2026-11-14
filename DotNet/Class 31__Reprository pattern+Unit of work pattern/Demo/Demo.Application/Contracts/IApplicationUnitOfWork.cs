using Demo.Application.Contracts.Repositories;
using Demo.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Contracts
{
    public interface IApplicationUnitOfWork : IUinitOfWork
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        ISupplierRepository Suppliers { get; }
        ICustomerRepository Customers { get; }
    }
}
