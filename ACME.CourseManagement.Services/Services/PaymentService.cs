using ACME.CourseManagement.ApplicationServices.Interfaces;
using ACME.CourseManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Services.Services
{
    public class PaymentService
    {
        private readonly IPaymentService _paymentService;
        private List<Course> _courses;
        public PaymentService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
            _courses = new List<Course>();
        }

        public void PaymentCourse(decimal payment, int courseId)
        {
            if (payment <= 0)
            {
                throw new Exception("payment cant be null o negative");
            }

            if (courseId <= 0) { throw new Exception("You must pass a course id to realize the payemnt"); }

            var course = _courses.SingleOrDefault(x => x.Id == courseId);


        }
    }
}
