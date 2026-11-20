using Cortex.Mediator.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Application.Features.BookManagement.Queries
{
    public class GetBookByIdQuery : ICommand<Book?>
    {
        public Guid Id { get; set; }
    }
}
