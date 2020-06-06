using Exmination.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.EnrollRepositry
{
    public interface IEnrollRepositry
    {
        public void Add(Enrollment enrollment);
        public void Remove(int id);
        public IEnumerable<Enrollment> GetEnrollment();
        public Enrollment GetEnrollmentById();
    }
}
