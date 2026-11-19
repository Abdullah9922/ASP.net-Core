using Application.Contracts.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class PatientRepository : Repository<Patient,Guid>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context) { }
    }
}
