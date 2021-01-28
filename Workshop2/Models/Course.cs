using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop2.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
