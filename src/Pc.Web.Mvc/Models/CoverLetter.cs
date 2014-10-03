using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pc.Web.Mvc.Models
{
    public class CurriculumVitae
    {
        public PersonalInformation Info { get; set; }
        public string DesiredJob { get; set; }
        public List<Experience> Experience { get; set; }
        
    }
}