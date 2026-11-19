using Application.Contracts;
using Application.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ApplicationUnitOfWork :  UnitOfWork, IApplicationUnitOfWork
    {
        public IPatientRepository PatientRepository { get; }
        public IDoctorRepository DoctorRepository {  get;  }

        public ApplicationUnitOfWork(ApplicationDbContext applicationDbContext, IPatientRepository patientRepository, IDoctorRepository doctorRepository) : base(applicationDbContext)
        {
            PatientRepository = patientRepository;
            DoctorRepository = doctorRepository;
        }
    }
}
