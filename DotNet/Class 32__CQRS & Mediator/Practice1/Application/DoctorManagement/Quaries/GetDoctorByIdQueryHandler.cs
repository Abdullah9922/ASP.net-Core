using Application.Contracts;
using Cortex.Mediator.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DoctorManagement.Quaries
{
    public class GetDoctorByIdQueryHandler : ICommandHandler<GetDoctorByIdQuery, Doctor?>
    {
        public readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public GetDoctorByIdQueryHandler(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public async Task<Doctor?> Handle(GetDoctorByIdQuery command, CancellationToken cancellationToken)
        {
            return await _applicationUnitOfWork.DoctorRepository.GetByIdAsync(command.Id, cancellationToken);
        }
    }
}
