using Cortex.Mediator.Commands;
using Demo.Application.Contracts;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Features.StudentManagement.Queries
{
    public class GetStudentByIdQureyHandler : ICommandHandler<GetStudentByIdQurey, Student?>
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public GetStudentByIdQureyHandler(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public  Task<Student?> Handle (GetStudentByIdQurey query, CancellationToken cancellationToken)
        {
            return _applicationUnitOfWork.StudentRepositroy.GetByIdAsync(query.Id, cancellationToken);
        }
    }
}
