using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Models;

namespace Workshop2.Interfaces
{
    public interface ICourseRepository
    {
        void CreateCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int id);
        IEnumerable<Course> SearchCourse(Func<Course, bool> func);
        IEnumerable<Course> GetAllCourse();
    }
}
