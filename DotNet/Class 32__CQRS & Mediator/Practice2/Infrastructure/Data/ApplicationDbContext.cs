using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<User> Users => Set<User>();
    }
}
