using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Models;

namespace Workshop2.Interfaces
{
   public  interface ITeacherRepository
    {
        void CreateTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);
        IEnumerable<Teacher> SearchTeacher(Func<Teacher, bool> func);
        IEnumerable<Teacher> GetAllTeacher();
    }
}
