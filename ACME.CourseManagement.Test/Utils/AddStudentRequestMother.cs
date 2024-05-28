using ACME.CourseManagement.ApplicationServices.DTOs.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Test.Utils
{
    public static class AddStudentRequestMother
    {
        public static StudentRequest Default => new StudentRequest { StudentName = "Default", StudentAge = 18 };
        public static StudentRequest Roberto => Default.WithName("Roberto").WithAge(25);
        public static StudentRequest Casimiro => Default.WithName("Casimiro").WithAge(105);
        public static StudentRequest Alejandra => Default.WithName("Alejandra").WithAge(40);
        public static StudentRequest Anacleta => Default.WithName(nameof(Anacleta)).WithAge(19);
        public static StudentRequest Rudolfina => Default.WithName(nameof(Rudolfina)).WithAge(7);


        public static StudentRequest WithName (this StudentRequest request, string name)
        {
            request.StudentName = name;
            return request;
        }

        public static StudentRequest WithAge (this StudentRequest request, int age)
        {
            request.StudentAge = age;
            return request;
        }
    }
}
