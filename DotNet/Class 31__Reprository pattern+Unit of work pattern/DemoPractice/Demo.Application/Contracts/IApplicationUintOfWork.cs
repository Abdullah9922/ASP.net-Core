using Demo.Application.Data.Repositories;
using Demo.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Contracts
{
    public interface IApplicationUintOfWork : IUintOfWork
    {
        public IStudentRepository StudentRepository { get; }
        public ITeacherRepository TeacherRepository { get; }
        public ICourseRepository CourseRepository { get; }
    }
}
