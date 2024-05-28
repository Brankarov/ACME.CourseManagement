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
    public class CourseService
    {
        private readonly IPaymentService _paymentService;
        private readonly ICourseRepository _courseRepository;
        public CourseService(IPaymentService paymentService, ICourseRepository courseRepository)
        {
            _paymentService = paymentService;
            _courseRepository = courseRepository;
        }

        public bool PaymentCourse(PaymentRequest request)
        {
            if (request.Amount <= 0)
            {
                throw new Exception("payment cant be null o negative");
            }


            var course = _courseRepository.GetEnumerables().SingleOrDefault(x => x.Name == request.CourseName);
            if (course == null)
            {
                return false;
            }
            if (request.Amount >= course.RegistrationFee)
            {
                _paymentService.ProccessPayment(request.Amount);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
