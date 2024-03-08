using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class StudentDbContext : DbContext
    {
        public readonly string _conn;
        public StudentDbContext()
        {
            _conn = "Server=.\\SQLEXPRESS;Database=TestDB;User Id=test;Password=12345; Trust Server Certificate = True ";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_conn);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEnrollment>().HasKey(x => new { x.StudentId, x.CourseId });

            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(ce => ce.Course)
                .WithMany(s => s.StudentEnrollments)
                .HasForeignKey(ce => ce.CourseId);
            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(ce => ce.Student)
                .WithMany(c => c.CourseEnrollments)
                .HasForeignKey(ce => ce.StudentId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
