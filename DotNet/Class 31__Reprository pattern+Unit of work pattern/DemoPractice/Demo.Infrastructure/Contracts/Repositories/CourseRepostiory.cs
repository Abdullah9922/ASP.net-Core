using Demo.Application.Data.Repositories;
using Demo.Domain.Entities;
using Demo.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Contracts.Repositories
{
    public class CourseRepostiory : Repository<Course,Guid>, ICourseRepository
    {
        public CourseRepostiory(ApplicationDbContext context) : base(context) { }
    }
}
