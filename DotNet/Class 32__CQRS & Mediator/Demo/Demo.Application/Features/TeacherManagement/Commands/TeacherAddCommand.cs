using Cortex.Mediator.Commands;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Demo.Application.Features.TeacherManagement.Commands
{
    public class TeacherAddCommand : ICommand<Guid>
    {
        public Teacher Teacher { get; set; }
    }
}
