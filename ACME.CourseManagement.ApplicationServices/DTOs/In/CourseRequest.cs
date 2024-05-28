using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.ApplicationServices.DTOs.In
{
    public class CourseRequest
    {
        public string? CourseName { get; set; }
        public decimal RegistrationFee { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
