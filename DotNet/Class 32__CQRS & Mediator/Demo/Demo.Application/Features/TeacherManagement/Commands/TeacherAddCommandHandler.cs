using Cortex.Mediator.Commands;
using Demo.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Features.TeacherManagement.Commands
{
    public class TeacherAddCommandHandler : ICommandHandler<TeacherAddCommand,Guid>
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public TeacherAddCommandHandler(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public async Task<Guid> Handle(TeacherAddCommand command, CancellationToken cancellationToken)
        {
            command.Teacher.Id = Guid.NewGuid();
            await _applicationUnitOfWork.TeacherRepositroy.AddAsync(command.Teacher, cancellationToken);
            await _applicationUnitOfWork.SaveAsync(cancellationToken);
            return command.Teacher.Id;
        }
    }
}
