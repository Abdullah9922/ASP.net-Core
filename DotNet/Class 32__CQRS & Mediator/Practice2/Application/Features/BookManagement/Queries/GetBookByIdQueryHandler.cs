using Application.Contracts;
using Cortex.Mediator.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.BookManagement.Queries
{
    public class GetBookByIdQueryHandler : ICommandHandler<GetBookByIdQuery, Book?>
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public GetBookByIdQueryHandler(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public async Task<Book?> Handle(GetBookByIdQuery query, CancellationToken cancellationToken)
        {
            return await _applicationUnitOfWork.BookRepository.GetByIdAsync(query.Id, cancellationToken);
        }
    }
}
