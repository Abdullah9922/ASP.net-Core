using Demo.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data.Repositories
{
    public abstract class Repository<TAggregateRoot, TKey> : IRepository<TAggregateRoot, TKey>, IDisposable
        where TAggregateRoot : class, IAggregateRoot<TKey>
        where TKey : IComparable<TKey>

    {
        private readonly DbContext _context;
        private readonly DbSet<TAggregateRoot> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TAggregateRoot>();
        }

        public void Add(TAggregateRoot aggregateRoot)
        {
            _dbSet.Add(aggregateRoot);
        }

        public void Remove(TAggregateRoot aggregateRoot)
        {
            _dbSet.Remove(aggregateRoot);
        }

        public void Update(TAggregateRoot aggregateRoot)
        {
            _dbSet.Update(aggregateRoot);
        }


        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
