using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
