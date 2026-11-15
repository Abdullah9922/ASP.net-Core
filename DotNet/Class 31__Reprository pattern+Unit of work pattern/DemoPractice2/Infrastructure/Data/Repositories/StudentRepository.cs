using Application.Contracts.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class StudentRepository : Repository<Student,Guid> ,IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context) { }
    }
}
