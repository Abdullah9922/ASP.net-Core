using Demo.Application.Data.Repositories;
using Demo.Domain.Entities;
using Demo.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Contracts.Repositories
{
    public class StudentRepository : Repository<Student,Guid>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context) { }
    }
}
