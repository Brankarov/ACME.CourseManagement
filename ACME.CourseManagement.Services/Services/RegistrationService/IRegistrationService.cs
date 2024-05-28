using ACME.CourseManagement.ApplicationServices.DTOs.In;
using ACME.CourseManagement.Domain;

namespace ACME.CourseManagement.Services.Services.RegistrationService
{
    public interface IRegistrationService
    {
        bool RegisterStudent(StudentRequest request);
        bool RegistrationCourse(CourseRequest request);
        IEnumerable<Student> GetAllRegisteredStudents();
        IEnumerable<Course> GetAllRegisteredCourses();
    }
}