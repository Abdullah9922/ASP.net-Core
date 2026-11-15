using Demo.Domain.Contracts;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Data.Repositories
{
    public interface ITeacherRepository : IRepository<Teacher,Guid>
    {
    }
}
