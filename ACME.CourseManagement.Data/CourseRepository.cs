using ACME.CourseManagement.Data.Interfaces;
using ACME.CourseManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Data
{
    public class CourseRepository : ICourseRepository
    {
        public List<Course> CoursesList = new List<Course>();
       
        public void Add(Course course)
        {
            CoursesList.Add(course);
        }

        public IEnumerable<Course> GetEnumerables()
        {
            return CoursesList;
        }
    }
}
