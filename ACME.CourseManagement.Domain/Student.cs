using ACME.CourseManagement.Domain.Common;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace ACME.CourseManagement.Domain
{
    public class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public List<Course> Courses { get; private set; }
        public Student( [NotNull]string name, int age) {

            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("the name can¡t be null");
            }

            if (age<=0)
            {
                throw new Exception("the number can't be zero o negative");
            }

            Name = name;
            Age = age;
            Courses = new List<Course>();
        }
        
        public void EnrollCourse( Course course)
        {
            if (course is null)
            {
                throw new Exception("A null course cant be assignated to a student");
            }
            this.Courses.Add(course);
        }

    }
}
