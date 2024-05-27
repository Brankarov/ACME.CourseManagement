using ACME.CourseManagement.Domain;
using ACME.CourseManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Services.Services
{
    public class RegistrationService
    {
        public List<Student> Students;


        public RegistrationService()
        {
            Students = new List<Student>();
        }

        public bool RegisterStudent(string name, int age)
        {
            try
            {
                if (age < Constants.MinimunAge && age > Constants.MaximunAge)
                {
                    throw new ArgumentException("The age is not allowed to enroll");
                }
                var student = new Student(name, age);

                Students.Add(student);
                return true;

            }
            catch (Exception e)
            {

                throw new Exception(e.ToString());
            }


        }
    }
}
