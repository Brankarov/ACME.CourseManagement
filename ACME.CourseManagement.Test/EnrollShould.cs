using ACME.CourseManagement.Services.Services.EnrollService;
using ACME.CourseManagement.Test.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Test
{
    public  class EnrollShould : ServicesTest
    {
        [Fact]
        public void EnrollSuccess()
        {
            var student = AddStudentRequestMother.Xiomara;
            registrationService.RegisterStudent(student);
            var course = AddCourseRequestMother.History;
            registrationService.RegistrationCourse(course);
            var request = AddEnrollRequest.Xiomara;
            var flag = enrollService.EnrollStudentInCourse(request);
            Assert.True(flag);
        }
        [Fact]
        public void EnrollFailure() 
        {
            var request = AddEnrollRequest.Erthelwed;
            var flag = enrollService.EnrollStudentInCourse(request);
            Assert.False(flag);
        }
        [Fact]
        public void EnrollWithStudentWithNoName()
        {
            var request = AddEnrollRequest.Roxxane;
            var flag = enrollService.EnrollStudentInCourse(request);
            Assert.False(flag);
        }
        [Fact]
        public void EnrollWithoutCourseName()
        {
            var request = AddEnrollRequest.Lucia;
            var flag = enrollService.EnrollStudentInCourse(request);
            Assert.False(flag);
        }

    }
}
