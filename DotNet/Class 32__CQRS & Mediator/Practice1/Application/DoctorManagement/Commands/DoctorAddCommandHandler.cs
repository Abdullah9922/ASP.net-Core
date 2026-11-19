using Application.Contracts;
using Cortex.Mediator.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Application.DoctorManagement.Commands
{
    public class DoctorAddCommandHandler : ICommandHandler<DoctorAddCommand, Doctor>
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public DoctorAddCommandHandler(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public async Task<Doctor> Handle(DoctorAddCommand command, CancellationToken cancellationToken)
        {
            command.Doctor.Id = Guid.NewGuid();
            await _applicationUnitOfWork.DoctorRepository.AddAsync(command.Doctor, cancellationToken);
            await _applicationUnitOfWork.SaveAsync(cancellationToken);
            return command.Doctor;
        }
    }
}
