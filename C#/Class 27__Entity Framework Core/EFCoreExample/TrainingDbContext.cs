using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EFCoreExample
{
    public class TrainingDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PracticeDataBase;User Id=DemoUser;Password=123456;TrustServerCertificate=True");
            }
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Student> Courses { get; set; }
    }
    
}
