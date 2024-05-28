using ACME.CourseManagement.ApplicationServices;
using ACME.CourseManagement.ApplicationServices.DTOs.In;
using ACME.CourseManagement.Data.Interfaces;
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
        private readonly ICourseRepository _courseRepository;
        private readonly IStudentRepository _studentRepository;

        public EnrollService(ICourseRepository courseRepository, IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }
        public bool EnrollStudentInCourse(EnrollRequest request)
        {
            try
            {
                var student = _studentRepository.GetEnumerables().SingleOrDefault(x => x.Name == request.StudentName);
                var course = _courseRepository.GetEnumerables().SingleOrDefault(x => x.Name == request.CourseName);
                if (student != null && course != null  )
                {
                    student.EnrollCourse(course);
                    return true;
                } else { return false; }
            }
            catch (Exception e)
            {
                throw new Exception("you can't enroll because: " + e);
            }

        }
    }
}
