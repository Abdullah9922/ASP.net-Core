using Application.Contracts;
using Cortex.Mediator.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.BookManagement.Commands
{
    public class BookAddCommandHandler : ICommandHandler<BookAddCommand, Book>
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public BookAddCommandHandler(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public async Task<Book> Handle(BookAddCommand command, CancellationToken cancellationToken)
        {
            command.Book.Id = Guid.NewGuid();
            await _applicationUnitOfWork.BookRepository.AddAsync(command.Book, cancellationToken);
            await _applicationUnitOfWork.SaveAsync(cancellationToken);
            return command.Book;
        }
    }
}
