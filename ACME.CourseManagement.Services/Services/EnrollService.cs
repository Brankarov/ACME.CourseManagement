using ACME.CourseManagement.ApplicationServices.Interfaces;
using ACME.CourseManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Services.Services
{
    public class EnrollService
    {
        private readonly IPaymentService _paymentService;
        private readonly List<Student> _students;
        private readonly List<Course> _courses;

        public EnrollService(IPaymentService paymentService)
        {
            _students = new List<Student>();
            _courses = new List<Course>();
        }
        public bool EnrollStudentInCourse(string studentName, int courseId)
        {
            try
            {
                var student = _students.SingleOrDefault(x => x.Name == studentName);
                var course = _courses.SingleOrDefault(x => x.Id == courseId);

                student.EnrollCourse(course);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("you can't enroll because: " + e);
            }

        }
    }
}
