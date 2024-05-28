using ACME.CourseManagement.ApplicationServices.DTOs.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Test.Utils
{
    public static class AddCourseRequestMother
    {
        public static CourseRequest Default => new CourseRequest { 
            CourseName = "Default", 
            RegistrationFee = 15000, 
            StarDate = new DateTime(2024,5,10), 
            EndDate = new DateTime(2024, 6, 10) };
        public static CourseRequest Math => Default.WithName("").WithRegistrationFee(25000);
        public static CourseRequest History => Default.WithName("History").WithRegistrationFee(30000);
        public static CourseRequest Chemistry => Default.WithName("Chemistry").WithRegistrationFee(90);
        public static CourseRequest Sociology => Default.WithName("Sociology").WithRegistrationFee(0);
        public static CourseRequest Physic => Default.WithName("Physic").WithRegistrationFee(750);

        public static CourseRequest WithName(this CourseRequest request, string name)
        {
            request.CourseName = name;
            return request;
        }

        public static CourseRequest WithRegistrationFee(this CourseRequest request, int cost)
        {
            request.RegistrationFee = cost;
            return request;
        }

        public static CourseRequest WithStarDate(this CourseRequest request, DateTime date)
        {
            request.StarDate = date;
            return request;
        }

        public static CourseRequest WithEndDate( this CourseRequest request, DateTime endDate)
        {
            request.EndDate = endDate;
            return request;
        }
    }
}
