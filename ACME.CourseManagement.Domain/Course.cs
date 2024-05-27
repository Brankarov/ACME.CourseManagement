using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public decimal RegistrationFee { get; private set; }
        public DateTime StarDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public Course(int id, string name, decimal registrationFee, DateTime starDate, DateTime endDate) {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("the course Name can't be null");
            }

            if(!(registrationFee >0))
            {
                throw new Exception("the registration fee can't be zero or null");
            }
            if (starDate > endDate) { throw new Exception("the stardate can't be after the end date"); }
            if (id <= 0) { throw new Exception("the id cant be zero o null"); } 

            Id = id + 1;
            Name = name;
            RegistrationFee = registrationFee;
            StarDate = starDate;
            EndDate = endDate;

        }
    }
}
