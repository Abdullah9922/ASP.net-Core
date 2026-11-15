using Application.Contracts.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class CourseRepository : Repository<Course, Guid> , ICourseRepository
    {
        public CourseRepository(ApplicationDbContext context) : base(context) { }
    }
}
