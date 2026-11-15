using Application.Contracts;
using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public abstract class UnitOfWork : IUnitOfWork,IDisposable
    {
        private readonly DbContext _context;

        public UnitOfWork (DbContext context)
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
