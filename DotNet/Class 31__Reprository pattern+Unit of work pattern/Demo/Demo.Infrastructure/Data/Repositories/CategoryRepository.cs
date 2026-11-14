using Demo.Application.Contracts.Repositories;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data.Repositories
{
    public class CategoryRepository : Repository<Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
