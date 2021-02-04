using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Data;
using Workshop2.Interfaces;
using Workshop2.Models;

namespace Workshop2.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly SchoolContext Database;

        public EnrollmentRepository(SchoolContext context)
        {
            this.Database = context;
        }

        public void CreateEnrollment(Enrollment enrollment)
        {
            Database.Enrollments.Add(enrollment);
        }

        public void DeleteEnrollment(int id)
        {
            Enrollment enrollment = Database.Enrollments.Find(id);
            if (enrollment != null)
            {
                Database.Enrollments.Remove(enrollment);
                Database.SaveChanges();

            }
        }

        public IEnumerable<Enrollment> GetAllEnrollment()
        {
            return Database.Enrollments;
        }

        public IEnumerable<Enrollment> SearchEnrollment(Func<Enrollment, bool> func)
        {
            return Database.Enrollments.Where(func);
        }

        public void UpdateEnrollment(Enrollment enrollment)
        {
            Database.Entry(enrollment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
