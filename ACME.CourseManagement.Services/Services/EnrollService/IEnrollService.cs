using ACME.CourseManagement.ApplicationServices.DTOs.In;

namespace ACME.CourseManagement.Services.Services.EnrollService
{
    public interface IEnrollService
    {
        bool EnrollStudentInCourse(EnrollRequest request);
    }
}