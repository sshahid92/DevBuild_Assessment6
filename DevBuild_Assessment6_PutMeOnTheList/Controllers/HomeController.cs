using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevBuild_Assessment6_PutMeOnTheList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rsvp()
        {
            return View();
        }

        public ActionResult BringADish()
        {
            return View();
        }
    }
}