using Application.Contracts.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class BookRepository : Repository<Book,Guid>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context) { }
    }
}
