using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExampleRepeat
{
    public class TrainingDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PracticeDataBaseRepeat;User Id=RepeatUser;Password=123456;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().ToTable("Topics");
            modelBuilder.Entity<CourseRegistration>().ToTable("CourseRegistrations");

            modelBuilder.Entity<CourseRegistration>().HasKey(cr => new { cr.CourseId, cr.StudentId });

            modelBuilder.Entity<Course>()
                .HasMany(x => x.TopicList)
                .WithOne(x => x.Course)
                .HasForeignKey(x => x.CourseId);

            modelBuilder.Entity<CourseRegistration>()
                .HasOne(x => x.Course)
                .WithMany(x => x.CourseRegistrations)
                .HasForeignKey(x => x.CourseId);

            modelBuilder.Entity<CourseRegistration>()
                .HasOne(x => x.Student)
                .WithMany(x => x.CourseRegistrations)
                .HasForeignKey(x => x.StudentId);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    
    }
}
