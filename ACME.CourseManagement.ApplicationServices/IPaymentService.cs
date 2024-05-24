using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.ApplicationServices
{
    public interface IPaymentService
    {
        bool ProccessPayment(decimal amount);
    }
}
