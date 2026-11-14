using Demo.Application.Contracts.Repositories;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data.Repositories
{
    public class CustomerRepository : Repository<Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
