using Demo.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Contracts
{
    public abstract class UintOfWork : IUintOfWork,IDisposable
    {

        private readonly DbContext _context;
        public UintOfWork(DbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
