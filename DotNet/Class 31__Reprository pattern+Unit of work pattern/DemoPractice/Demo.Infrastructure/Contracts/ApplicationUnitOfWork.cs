using Demo.Application.Contracts;
using Demo.Application.Data.Repositories;
using Demo.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Contracts
{
    public class ApplicationUnitOfWork : UintOfWork, IApplicationUintOfWork
    {
        public IStudentRepository StudentRepository {  get; private set; }
        public ITeacherRepository TeacherRepository { get; private set; }
        public ICourseRepository CourseRepository { get; private set; }

        public ApplicationUnitOfWork(ApplicationDbContext applicationDbContext, IStudentRepository studentRepository, ITeacherRepository teacherRepository, ICourseRepository courseRepository) : base(applicationDbContext)
        {
            StudentRepository = studentRepository;
            TeacherRepository = teacherRepository;
            CourseRepository = courseRepository;
        }
    }
}
