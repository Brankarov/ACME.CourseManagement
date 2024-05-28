using ACME.CourseManagement.ApplicationServices.DTOs.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Test.Utils
{
    public static class AddPaymentRequest
    {
        public static PaymentRequest Default = new PaymentRequest { CourseName = "Default", Amount = 0};
        public static PaymentRequest BigMoney = new PaymentRequest { CourseName = "History", Amount = 0};
        public static PaymentRequest LowMoney = new PaymentRequest { CourseName = "Chemistry", Amount = 0};
        public static PaymentRequest wrongCourse = new PaymentRequest { CourseName = "Laws", Amount = 0};
        public static PaymentRequest Debts = new PaymentRequest { CourseName = "Math", Amount = 0};

        public static PaymentRequest WithCourse( this PaymentRequest request, string courseName)
        {
            request.CourseName = courseName;
            return request;
        }

        public static PaymentRequest WithAmount( this PaymentRequest request, int amount)
        {
            request.Amount = amount;
            return request;
        }
    }
}
