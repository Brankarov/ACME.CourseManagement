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
            enrollService.EnrollStudentInCourse(request);
            Assert.Throws<Exception>(() => { enrollService.EnrollStudentInCourse(request); });
        }
        [Fact]
        public void EnrollWithoutCourseName()
        {
            var request = AddEnrollRequest.Lucia;
            enrollService.EnrollStudentInCourse(request);
            Assert.Throws<Exception>(() => { enrollService.EnrollStudentInCourse(request); });
        }

    }
}
