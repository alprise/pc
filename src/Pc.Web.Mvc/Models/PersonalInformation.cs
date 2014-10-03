using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pc.Web.Mvc.Models
{
    public class PersonalInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Addresse { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Citizenship { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get { return FirstName + " " + LastName; } }
    }
}
