using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pc.Web.Mvc.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Details { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Full { get { return string.Format("{0} {1}, {2} {3} ({4})", Street, Number, PostalCode, City, Country); } }
    }
}
