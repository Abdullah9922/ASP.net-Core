using Application.Contracts.Repositories;
using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IBookRepository BookRepository { get; }
        IUserRepository UserRepository { get; }
    }
}
