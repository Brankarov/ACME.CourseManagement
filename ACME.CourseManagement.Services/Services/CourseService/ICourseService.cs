using ACME.CourseManagement.ApplicationServices.DTOs.In;

namespace ACME.CourseManagement.Services.Services.CourseService
{
    public interface ICourseService
    {
        bool PaymentCourse(PaymentRequest request);
    }
}