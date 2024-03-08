using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Fees { get; set; }
        public bool IsActive { get; set; }
        public List<Topic> Topics { get; set; }
        public List<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
