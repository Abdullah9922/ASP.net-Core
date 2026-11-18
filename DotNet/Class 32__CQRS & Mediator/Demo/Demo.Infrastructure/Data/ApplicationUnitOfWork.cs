using Demo.Application.Contracts;
using Demo.Application.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Data
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IStudentRepositroy StudentRepositroy { get; }
        public ITeacherRepository TeacherRepositroy { get; }

        public ApplicationUnitOfWork(ApplicatonDbContext context, IStudentRepositroy studentRepositroy, ITeacherRepository teacherRepository) : base(context)
        {
            StudentRepositroy = studentRepositroy;
            TeacherRepositroy = teacherRepository;
        }
    }
}
