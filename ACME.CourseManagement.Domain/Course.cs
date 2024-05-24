using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Domain
{
    public class Course
    {
        public string Name { get; private set; }
        public decimal RegistrationFee { get; private set; }
        public DateTime StarDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public Course( string name, decimal registrationFee, DateTime starDate, DateTime endDate) {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("the course Name can't be null");
            }

            if(!(registrationFee >0))
            {
                throw new Exception("the registration fee can't be zero or null");
            }
            if (starDate > endDate) { throw new Exception("the stardate can't be after the end date"); }

            Name = name;
            RegistrationFee = registrationFee;
            StarDate = starDate;
            EndDate = endDate;

        }
    }
}
