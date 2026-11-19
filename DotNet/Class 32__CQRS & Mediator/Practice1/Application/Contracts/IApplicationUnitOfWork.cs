using Application.Contracts.Repositories;
using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IPatientRepository PatientRepository { get; }
        IDoctorRepository DoctorRepository { get; }
    }
}
