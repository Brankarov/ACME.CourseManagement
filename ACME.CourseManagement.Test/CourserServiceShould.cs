using ACME.CourseManagement.Test.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Test
{
    public class CourserServiceShould : ServicesTest
    {
        [Fact]
        public void PaymentSuccessful()
        {
            var course = AddCourseRequestMother.History;
            registrationService.RegistrationCourse(course);
            var request = AddPaymentRequest.BigMoney;
            var result = courseService.PaymentCourse(request);
            Assert.True(result);
        }
        [Fact]
        public void PaymentFailed() 
        {
            var request = AddPaymentRequest.LowMoney;
            var result = courseService.PaymentCourse(request);
            Assert.False(result);
        }
        [Fact]
        public void PaymentWithWrongCourse()
        {
            var request = AddPaymentRequest.wrongCourse;
            var flasg = courseService.PaymentCourse(request);
            Assert.False(flasg);
        }
        [Fact]
        public void PaymentWithnegativeMoney() 
        {
            var request = AddPaymentRequest.Debts;
            Assert.Throws<Exception>(() => { courseService.PaymentCourse(request); }) ;
        }
    }
}
