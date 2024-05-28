using ACME.CourseManagement.Test.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Test
{
    public class RegistrationShould : ServicesTest
    {
        [Fact]
        public void RegistrationStudent() 
        {
            var request = AddStudentRequestMother.Roberto;

            registrationService.RegisterStudent(request);

            var student = registrationService.GetAllRegisteredStudents().SingleOrDefault();
            Assert.NotNull(student);
            Assert.Equal(request.StudentName, student.Name);
            Assert.Equal(request.StudentAge, student.Age);
        }

        [Fact]
        public void RegistrationwithNotAllowedAge()
        {
            var request = AddStudentRequestMother.Rudolfina;
            Assert.Throws<Exception>(() => { registrationService.RegisterStudent(request); });
        }
        [Fact]
        public void RegistrarionStudentWithNoName()
        {
            var request = AddStudentRequestMother.Alejandra; 
            Assert.Throws<Exception>(() => { registrationService.RegisterStudent(request); });
        }
        [Fact]
        public void RegistrationStudentwithNoAge()
        {
            var request = AddStudentRequestMother.Anacleta;
            Assert.Throws<Exception>(() => { registrationService.RegisterStudent(request); });
        }
        [Fact]
        public void RegistrationWithStudentTooOld()
        {
            var request = AddStudentRequestMother.Casimiro;
            Assert.Throws<Exception>(() => { registrationService.RegisterStudent(request); });
        }
        [Fact]
        public void RegistrationWhenAStudentAlreadyExist()
        {
            var request = AddStudentRequestMother.Roberto;
            registrationService.RegisterStudent(request);
            var student = registrationService.GetAllRegisteredStudents().SingleOrDefault();
            var request2 = AddStudentRequestMother.Roberto;
            Assert.Throws<Exception>(() => { registrationService.RegisterStudent(request2); });
        }
        [Fact]
        public void RegistrationCourse()
        {
            var request = AddCourseRequestMother.History;
            registrationService.RegistrationCourse(request);
            var course = registrationService.GetAllRegisteredCourses().SingleOrDefault();
            Assert.NotNull(course);
            Assert.Equal(request.CourseName, course.Name);
            Assert.Equal(request.RegistrationFee, course.RegistrationFee);
            Assert.Equal(request.StarDate, course.StarDate);
            Assert.Equal(request.EndDate, course.EndDate);
        }
        [Fact]
        public void RegistrationCourseAlreadyExist()
        {
            var request = AddCourseRequestMother.History;
            var request2 = AddCourseRequestMother.History;
            registrationService.RegistrationCourse(request);
            Assert.Throws<Exception>(() =>{ registrationService.RegistrationCourse(request2); });
        }
        [Fact]
        public void RegistrationCourseWithNullName()
        {
            var request = AddCourseRequestMother.Math;
            Assert.Throws<Exception>(() => { registrationService.RegistrationCourse(request); });
        }
        [Fact]
        public void RegistrationCourseWithNullRegistrationFee()
        {
            var request = AddCourseRequestMother.Sociology;
            Assert.Throws<Exception>( () => {  registrationService.RegistrationCourse(request); });
        }
    }
}
