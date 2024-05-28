using ACME.CourseManagement.ApplicationServices.DTOs.In;
using ACME.CourseManagement.Data.Interfaces;
using ACME.CourseManagement.Domain;
using ACME.CourseManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Services.Services.RegistrationService
{
    public class RegistrationService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public RegistrationService(IStudentRepository studentRepository, ICourseRepository courseRepository)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        public bool RegisterStudent(StudentRequest request)
        {
            try
            {
                if (request.StudentAge < Constants.MinimunAge && request.StudentAge > Constants.MaximunAge)
                {
                    throw new ArgumentException("The age is not allowed to enroll");
                }

                var student = new Student(request.StudentName, request.StudentAge);

                _studentRepository.Add(student);
                return true;

            }
            catch (Exception e)
            {

                throw new Exception(e.ToString());
            }
        }

        public bool RegistrationCourse(CourseRequest request)
        {
            try
            {
                var course = new Course(request.CourseName, request.RegistrationFee, request.StarDate, request.EndDate);
                if (course != null)
                {
                    _courseRepository.Add(course);
                    return true;
                }
                else { return false; }

            }
            catch (Exception e)
            {

                throw new Exception(e.ToString());
            }
        }
    }
}
