using Cortex.Mediator;
using Cortex.Mediator.Commands;
using Demo.Application.Contracts;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Features.TeacherManagement.Queries
{
    public class GetTeacherByIdQureyHandler : ICommandHandler<GetTeacherByIdQurey, Teacher?>
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public GetTeacherByIdQureyHandler(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public async Task<Teacher?> Handle(GetTeacherByIdQurey qurey, CancellationToken cancellationToken)
        {
            return await _applicationUnitOfWork.TeacherRepositroy.GetByIdAsync(qurey.Id, cancellationToken);
        }
    }
}
