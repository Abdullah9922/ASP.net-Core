using Demo.Application.Contracts;
using Demo.Application.Data.Repositories;
using Demo.Infrastructure.Contracts;
using Demo.Infrastructure.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static void AddDepedency(this IServiceCollection services )
        {
            services.AddScoped<IApplicationUintOfWork, ApplicationUnitOfWork>();

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<ICourseRepository, CourseRepostiory>();
        }
    }
}
