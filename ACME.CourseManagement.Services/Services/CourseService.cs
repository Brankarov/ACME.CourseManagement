using ACME.CourseManagement.ApplicationServices;
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

        public bool PaymentCourse(decimal payment, int courseId)
        {
            if (payment <= 0)
            {
                throw new Exception("payment cant be null o negative");
            }

            if (courseId <= 0) { throw new Exception("You must pass a course id to realize the payemnt"); }

            var course = _courseRepository.GetEnumerables().SingleOrDefault(x => x.Id == courseId);
            if (payment >= course.RegistrationFee)
            {
                _paymentService.ProccessPayment(payment);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
