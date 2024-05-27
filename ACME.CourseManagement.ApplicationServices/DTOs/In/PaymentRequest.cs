using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.ApplicationServices.DTOs.In
{
    public class PaymentRequest
    {
        public decimal Amount { get; set; }
        public int CourseId { get; set; }
    }
}
