using DevBuild_Assessment6_PutMeOnTheList.Models;
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
        [HttpPost]
        public ActionResult Rsvp(Rsvp teamMember)
        {
            var teamMemberRsvp = teamMember;
            return RedirectToAction("RsvpComplete", teamMemberRsvp);
        }

        public ActionResult RsvpComplete(Rsvp teamMemberRsvp)
        {
            return View(teamMemberRsvp);
        }
        public ActionResult BringADish()
        {
            return View();
        }
    }
}