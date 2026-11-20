using Domain.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Repositories
{
    public interface IBookRepository : IRepository<Book,Guid>
    {
    }
}
