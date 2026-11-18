using Cortex.Mediator.Commands;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Features.StudentManagement.Queries
{
    public class GetStudentByIdQurey : ICommand<Student?>
    {
       public Guid Id { get; set; } 
    }
}
