using Pc.Web.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pc.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CV()
        {
            var model = new CurriculumVitae
            {
                Info = new PersonalInformation
                {
                    FirstName = "Vasile Cristian",
                    LastName = "Prisecaru",
                    Addresse = new Address
                    {
                        Street = "Madrider Ring",
                        Number = "54",
                        PostalCode = "97084",
                        City = "Würzburg",
                        Country = "Germany"
                    },
                    BirthDate = new DateTime(1981, 1, 1),
                    Citizenship = "Romanian"
                }
            };

            return View(model);
        }
        public ActionResult Index()
        {
            var model = new CurriculumVitae
            {
                Info = new PersonalInformation
                {
                    Addresse = new Address
                    {
                        Street = "Madrider Ring",
                        Number = "54",
                        PostalCode = "97084",
                        City = "Würzburg",
                        Country = "Germany"
                    },
                    BirthDate = new DateTime(1981, 1, 1),
                    Citizenship = "Romanian"
                }
            };
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}