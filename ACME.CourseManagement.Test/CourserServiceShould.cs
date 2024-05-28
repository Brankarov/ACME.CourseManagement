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
            courseService.PaymentCourse(request);
            Assert.Throws<Exception>(() => { courseService.PaymentCourse(request); });
        }
        [Fact]
        public void PaymentWithnegativeMoney() 
        {
            var request = AddPaymentRequest.Debts;
            courseService.PaymentCourse(request);
            Assert.Throws<Exception>(() => { courseService.PaymentCourse(request); }) ;
        }
    }
}
