using ACME.CourseManagement.Data.Interfaces;
using ACME.CourseManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Data
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> StudentList = new List<Student>();

        public void Add( Student student)
        {
            StudentList.Add(student);
        }

        public IEnumerable<Student> GetEnumerables()
        {
            return StudentList;
        }
    }
}
