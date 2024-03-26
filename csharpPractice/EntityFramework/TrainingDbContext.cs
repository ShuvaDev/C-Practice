using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EntityFramework
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        public TrainingDbContext()
        {
            _connectionString = "Server=.\\SQLEXPRESS;Database=TestDB;User Id=test;Password=12345; Trust Server Certificate = True ";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Since there is not any DbSet Property for Topic Entity, therefore created table will be named as Topic.
             * If we want to change default name Topic to Topics then we must be add below statement. */
            modelBuilder.Entity<Topic>().ToTable("Topics");

            /* If we want to set a primary key which is combination of two key(StudentId and CourseId) */
            modelBuilder.Entity<CourseEnrollment>().HasKey(x => new { x.StudentId, x.CourseId });

            modelBuilder.Entity<Course>()
                .HasMany(x => x.Topics)
                .WithOne(y => y.Course)
                .HasForeignKey(z => z.CourseID);

            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(x => x.Student)
                .WithMany(y => y.CourseEnrollments)
                .HasForeignKey(z => z.StudentId);

            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(x => x.Course)
            .WithMany(y => y.CourseEnrollments)
                .HasForeignKey(z => z.CourseId);

            //Switching off Identity for Numeric Primary Key
            /*
            modelBuilder.Entity<Topic>()
                .Property(t => t.Id)
                .ValueGeneratedNever(); // // Turn off identity/auto-increment
            */
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Course> Courses { get; set; }
        //public DbSet<Topic> Topics { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
