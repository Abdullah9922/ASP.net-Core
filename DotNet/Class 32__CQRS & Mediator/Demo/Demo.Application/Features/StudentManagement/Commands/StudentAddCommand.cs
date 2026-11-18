using Cortex.Mediator.Commands;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Demo.Application.Features.StudentManagement.Commands
{
    public class StudentAddCommand : ICommand<Student>
    {
        public Student Student { get; set; }
    }
}
