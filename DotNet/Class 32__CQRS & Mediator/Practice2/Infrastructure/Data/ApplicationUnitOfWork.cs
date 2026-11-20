using Application.Contracts;
using Application.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IBookRepository BookRepository { get; }

        public IUserRepository UserRepository { get; }

        public ApplicationUnitOfWork(ApplicationDbContext context, IBookRepository bookRepository, IUserRepository userRepository) : base(context) 
        {
            BookRepository = bookRepository;
            UserRepository = userRepository;
        }
    }
}
