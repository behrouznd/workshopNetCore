using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Models;

namespace Workshop2.Interfaces
{
    public interface IStudentRepository
    {
        void CreateStudent(Student student);
        void updateStudent(Student student);
        void DeleteStudent(int id);
        IEnumerable<Student> SearchStudent(Func<Student , bool> func);
        IEnumerable<Student> GetAllStudents();

    }
}
