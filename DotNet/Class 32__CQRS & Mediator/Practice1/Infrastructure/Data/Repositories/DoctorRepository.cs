using Application.Contracts.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public  class DoctorRepository : Repository<Doctor,Guid>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context) { }
    }
}
