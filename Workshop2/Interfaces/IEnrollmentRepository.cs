using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Models;

namespace Workshop2.Interfaces
{
    public interface IEnrollmentRepository
    {
        void CreateEnrollment(Enrollment enrollment);
        void UpdateEnrollment(Enrollment enrollment);
        void DeleteEnrollment(int id);
        IEnumerable<Enrollment> SearchEnrollment(Func<Enrollment, bool> func);
        IEnumerable<Enrollment> GetAllEnrollment();
    }
}
