using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Student class many to many relationship
namespace EntityFramework
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double CGPA { get; set; }
        public List<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
