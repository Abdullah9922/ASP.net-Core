using Demo.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data
{
    public abstract class UnitOfWork : IUinitOfWork, IDisposable
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
