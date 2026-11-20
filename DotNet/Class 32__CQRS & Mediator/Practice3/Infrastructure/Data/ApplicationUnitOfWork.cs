using Application.Contracts;
using Application.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IStudentRepository StudentRepository {  get; }
        public ITeacherRepository TeacherRepository { get; }

        public ApplicationUnitOfWork(ApplicationDbContext context, IStudentRepository studentRepository, ITeacherRepository teacherRepository) : base(context)
        {
            StudentRepository = studentRepository;
            TeacherRepository = teacherRepository;
        }
    }
}
