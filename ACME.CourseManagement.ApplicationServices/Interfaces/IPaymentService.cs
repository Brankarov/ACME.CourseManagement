using ACME.CourseManagement.ApplicationServices.DTOs.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.ApplicationServices.Interfaces
{
    public interface IPaymentService
    {
        bool ProccessPayment(PaymentRequest request);
    }
}
