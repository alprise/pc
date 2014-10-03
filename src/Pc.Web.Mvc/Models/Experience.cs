using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pc.Web.Mvc.Models
{
    public class Experience
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobTitle { get; set; }
        public Company Company { get; set; }
        public List<Responsability> Responsabilities { get; set; }
    }
}
