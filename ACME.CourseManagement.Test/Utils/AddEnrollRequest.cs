using ACME.CourseManagement.ApplicationServices.DTOs.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Test.Utils
{
    public static class AddEnrollRequest
    {
        public static EnrollRequest Default => new EnrollRequest { StudentName = "Default", CourseName ="Default"};
        public static EnrollRequest Xiomara => Default.WithStudent("Xiomara").WithCourse("History");
        public static EnrollRequest Erthelwed => Default.WithStudent("Erthelwed").WithCourse("Chemestry");
        public static EnrollRequest Roberto => Default.WithStudent("Roberto").WithCourse("IndustrialProccess");
        public static EnrollRequest Roxxane => Default.WithStudent("").WithCourse("History");
        public static EnrollRequest Lucia => Default.WithStudent("Lucia").WithCourse("");


        public static EnrollRequest WithStudent( this EnrollRequest request, string name)
        {
            request.StudentName = name;
            return request;
        }

        public static EnrollRequest WithCourse( this EnrollRequest request, string course)
        {
            request.CourseName = course;
            return request;
        }
    }
}
