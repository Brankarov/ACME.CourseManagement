using ACME.CourseManagement.ApplicationServices;
using ACME.CourseManagement.Data;
using ACME.CourseManagement.Data.Interfaces;
using ACME.CourseManagement.Services.Services.CourseService;
using ACME.CourseManagement.Services.Services.EnrollService;
using ACME.CourseManagement.Services.Services.RegistrationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Test.Utils
{
    public class ServicesTest
    {
        //protected OfficeRentalService Service;
        protected IEnrollService enrollService;
        protected ICourseService courseService;
        protected IRegistrationService registrationService;
        protected IPaymentService paymentService;
        protected IStudentRepository studentRepository;
        protected ICourseRepository courseRepository;
        public ServicesTest()
        {
            studentRepository = new StudentRepository();
            courseRepository = new CourseRepository();
            enrollService = new EnrollService(courseRepository, studentRepository);
            courseService = new CourseService(paymentService, courseRepository);
            registrationService = new RegistrationService(studentRepository, courseRepository);
        }
    }
}
