using Demo.Application.Contracts.Repositories;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data.Repositories
{
    public class TeacherRepository : Repository<Teacher,Guid>, ITeacherRepository
    {
        public TeacherRepository(ApplicatonDbContext context) : base(context) { }
    }
}
