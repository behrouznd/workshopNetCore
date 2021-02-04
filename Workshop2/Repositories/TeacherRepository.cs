using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Data;
using Workshop2.Interfaces;
using Workshop2.Models;

namespace Workshop2.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolContext Database;

        public TeacherRepository(SchoolContext context)
        {
            this.Database = context;
        }


        public void CreateTeacher(Teacher teacher)
        {
            Database.Teachers.Add(teacher);
        }

        public void DeleteTeacher(int id)
        {
            Teacher teacher = Database.Teachers.Find(id);
            if (teacher != null)
            {
                Database.Teachers.Remove(teacher);
                Database.SaveChanges();

            }
        }

        public IEnumerable<Teacher> GetAllTeacher()
        {
            return Database.Teachers;
        }

        public IEnumerable<Teacher> SearchTeacher(Func<Teacher, bool> func)
        {
            return Database.Teachers.Where(func);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            Database.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
