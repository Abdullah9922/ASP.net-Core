using Application.Contracts;
using Application.Contracts.Repositories;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Extentions
{
    public static class DependencyInjection
    {
        public static void AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IApplicationUintOfWork, ApplicationUnitOfWork>();

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
