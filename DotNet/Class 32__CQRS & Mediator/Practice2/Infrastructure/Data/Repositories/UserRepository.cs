using Application.Contracts.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<User,  Guid> , IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { } 
    }
}
