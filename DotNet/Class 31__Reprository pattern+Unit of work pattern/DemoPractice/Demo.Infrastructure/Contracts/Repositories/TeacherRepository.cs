using Demo.Application.Data.Repositories;
using Demo.Domain.Entities;
using Demo.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Contracts.Repositories
{
    public class TeacherRepository : Repository<Teacher,Guid>,ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext context) : base(context) { }
    }
}
