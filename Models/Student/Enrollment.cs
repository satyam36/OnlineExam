using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Exmination.Models.Student
{
    public class Enrollment
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Father { get; set; }
        public string Mobile { get; set; }

        public Address ParmanentAddress { get; set; }
        public bool SameAsParmanent { get; set; }
        public Address CorrespondanceAddress { get; set; }

        public Programm Program { get; set; }
        public RequiredSubject RequiredSubject { get; set; }
        public OptionalSubject OptionalSubject { get; set; }

        public Url Profile { get; set; }
        public Url Matric { get; set; }
        public Url Secondary { get; set; }
    }
}
