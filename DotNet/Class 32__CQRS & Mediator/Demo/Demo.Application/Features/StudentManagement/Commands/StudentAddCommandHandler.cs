using Cortex.Mediator.Commands;
using Demo.Application.Contracts;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Features.StudentManagement.Commands
{
    public  class StudentAddCommandHandler : ICommandHandler<StudentAddCommand,Student>
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public StudentAddCommandHandler(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public async Task<Student> Handle(StudentAddCommand command, CancellationToken cancellationToken)
        {
            command.Student.Id = Guid.NewGuid();
            await _applicationUnitOfWork.StudentRepositroy.AddAsync(command.Student, cancellationToken);
            await _applicationUnitOfWork.SaveAsync(cancellationToken);
            return command.Student;
        }
    }
}
