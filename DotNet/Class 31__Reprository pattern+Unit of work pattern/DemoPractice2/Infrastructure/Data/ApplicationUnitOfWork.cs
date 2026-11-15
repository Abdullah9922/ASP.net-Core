using Application.Contracts;
using Application.Contracts.Repositories;
using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ApplicationUnitOfWork : IApplicationUintOfWork 
    {
        public IStudentRepository StudentRepository {  get; }
        public ITeacherRepository TeacherRepository { get; }
        public ICourseRepository CourseRepository { get; }

        public ApplicationUnitOfWork(ApplicationDbContext context, IStudentRepository studentRepository, ITeacherRepository teacherRepository, ICourseRepository courseRepository)
        {
            StudentRepository = studentRepository;
            TeacherRepository = teacherRepository;
            CourseRepository = courseRepository;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
