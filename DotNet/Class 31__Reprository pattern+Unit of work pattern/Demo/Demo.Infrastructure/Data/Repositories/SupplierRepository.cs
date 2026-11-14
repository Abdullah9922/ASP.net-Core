using Demo.Application.Contracts.Repositories;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data.Repositories
{
    public class SupplierRepository : Repository<Supplier, Guid>, ISupplierRepository
    {
        public SupplierRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
