using Demo.Domain.Contracts;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Contracts.Repositories
{
    public interface ISupplierRepository : IRepository<Supplier,Guid>
    {
    }
}
