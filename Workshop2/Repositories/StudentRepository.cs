using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Data;
using Workshop2.Interfaces;
using Workshop2.Models;

namespace Workshop2.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private readonly SchoolContext Database;

        public StudentRepository(SchoolContext context)
        {
            this.Database = context;
        }

        public void CreateStudent(Student student)
        {
            Database.Students.Add(student);
            Database.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            Student student = Database.Students.Find(id);
            if (student != null)
            {
                Database.Students.Remove(student);
                Database.SaveChanges();
            }
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return Database.Students;
        }

        public IEnumerable<Student> SearchStudent(Func<Student , bool> func)
        {
            return Database.Students.Where(func);
        }

        public void updateStudent(Student student)
        {
            Database.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Database.SaveChanges();
        }
    }
}
