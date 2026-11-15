using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public abstract class Repository<TAggregateRoot, TKey> : IRepository<TAggregateRoot, TKey>, IDisposable
        where TAggregateRoot: class , IAggregateRoot<TKey>
        where TKey : IComparable<TKey>
    {
        private readonly DbContext _context;
        private readonly DbSet<TAggregateRoot> _dbset;

        public Repository(DbContext context)
        {
            _context = context;
            _dbset = context.Set<TAggregateRoot>();
        }
        public void Add(TAggregateRoot aggregateRoot)
        {
            _dbset.Add(aggregateRoot);
        }

        public void Reomve(TAggregateRoot aggregateRoot)
        {
            _dbset.Remove(aggregateRoot);
        }

        public void Update(TAggregateRoot aggregateRoot)
        {
            _dbset.Update(aggregateRoot);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
