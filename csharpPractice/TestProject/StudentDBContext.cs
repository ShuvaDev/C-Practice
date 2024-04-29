using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class StudentDBContext : DbContext
    {
        private string _conn;
        public StudentDBContext()
        {
            _conn = "Server=DESKTOP-3UBD9T3\\SQLEXPRESS;Database=TestDB;User Id=test;Password=12345;TrustServerCertificate = true;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
