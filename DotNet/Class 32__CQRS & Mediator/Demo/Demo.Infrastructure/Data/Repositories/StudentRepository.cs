using Demo.Application.Contracts.Repositories;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data.Repositories
{
    public class StudentRepository : Repository<Student,Guid>, IStudentRepositroy
    {
        public StudentRepository(ApplicatonDbContext context) : base(context) { }
    }
}
