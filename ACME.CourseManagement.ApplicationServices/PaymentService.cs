using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.ApplicationServices
{
    public class PaymentService : IPaymentService
    {
        public bool ProccessPayment(decimal payment)
        {
            return true;
        }
    }
}
