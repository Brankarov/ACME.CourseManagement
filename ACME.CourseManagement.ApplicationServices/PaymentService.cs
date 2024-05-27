using ACME.CourseManagement.ApplicationServices.DTOs.In;
using ACME.CourseManagement.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.ApplicationServices
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentCourse _paymentCourse;

        public PaymentService(IPaymentCourse paymentCourse)
        {
            _paymentCourse = paymentCourse;
        }


        public bool ProccessPayment(PaymentRequest request)
        {
            var course = _paymentCourse.GetCourse(request.CourseId);
            if (course == null)
            {
                throw new ArgumentException("El curso no existe.");
            }
            return _paymentCourse.ProccessPayment(request.Amount, course);
        }
    }
}
