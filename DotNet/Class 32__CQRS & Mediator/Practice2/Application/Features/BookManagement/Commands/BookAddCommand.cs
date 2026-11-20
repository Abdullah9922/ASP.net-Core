using Cortex.Mediator.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Application.Features.BookManagement.Commands
{
    public class BookAddCommand : ICommand<Book>
    {
        public Book Book { get; set; }
    }
}
