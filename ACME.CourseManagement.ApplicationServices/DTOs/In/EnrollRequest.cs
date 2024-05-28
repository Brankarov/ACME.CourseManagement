using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.ApplicationServices.DTOs.In
{
    public  class EnrollRequest
    {
        public string? StudentName { get; set; }
        public string? CourseName { get; set; }
    }
}
