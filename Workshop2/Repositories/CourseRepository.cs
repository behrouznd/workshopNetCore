using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Data;
using Workshop2.Interfaces;
using Workshop2.Models;

namespace Workshop2.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolContext Database;

        public CourseRepository(SchoolContext context)
        {
            this.Database = context;
        }

        public void CreateCourse(Course course)
        {
            Database.Courses.Add(course);
        }

        public void DeleteCourse(int id)
        {
            Course course = Database.Courses.Find(id);
            if (course != null)
            {
                Database.Courses.Remove(course);
                Database.SaveChanges();

            }
        }

        public IEnumerable<Course> GetAllCourse()
        {
            return Database.Courses;
        }

        public IEnumerable<Course> SearchCourse(Func<Course, bool> func)
        {
            return Database.Courses.Where(func);
        }

        public void UpdateCourse(Course course)
        {
            Database.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
