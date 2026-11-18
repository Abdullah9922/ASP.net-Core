using Cortex.Mediator.Commands;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Demo.Application.Features.TeacherManagement.Queries
{
    public class GetTeacherByIdQurey : ICommand<Teacher?>
    {
        public Guid Id { get; set; }
    }
}
