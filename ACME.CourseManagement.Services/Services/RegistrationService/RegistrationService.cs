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
    public class RegistrationService : IRegistrationService
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
                if (request == null)
                {
                    throw new Exception("request is null");
                }
                if (request.StudentAge < Constants.MinimunAge || request.StudentAge > Constants.MaximunAge)
                {
                    throw new Exception("The age is not allowed to enroll");
                }

                var student = new Student(request.StudentName, request.StudentAge);
                var samestudent = _studentRepository.GetEnumerables().Any(X => X.Name == request.StudentName);
                if (!samestudent)
                {
                    _studentRepository.Add(student);
                    return true;
                } else { throw new Exception("can't be added the same student"); }

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
                if (request == null)
                {
                    throw new Exception("the argegument is null");
                }
                if (request.StarDate == new DateTime(0,0,0) || request.EndDate == new DateTime(0,0,01))
                {
                    throw new Exception("THE DATES can't be null");
                }
                var course = new Course(request.CourseName, request.RegistrationFee, request.StarDate, request.EndDate);
                if (course != null)
                {
                    if (!(_courseRepository.GetEnumerables().Any(x => x.Name == request.CourseName)))
                    {
                        _courseRepository.Add(course);
                        return true;
                    }
                    else { throw new Exception("cantbe added the same course"); }
                }
                else { return false; }

            }
            catch (Exception e)
            {

                throw new Exception(e.ToString());
            }
        }
        public IEnumerable<Student> GetAllRegisteredStudents()
        {
            return _studentRepository.GetEnumerables();
        }

        public IEnumerable<Course> GetAllRegisteredCourses()
        {
            return _courseRepository.GetEnumerables();
        }
    }
}
