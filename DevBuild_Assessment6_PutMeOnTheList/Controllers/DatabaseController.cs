using DevBuild_Assessment6_PutMeOnTheList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace DevBuild_Assessment6_PutMeOnTheList.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        public ActionResult Index()
        {
            PartyDBEntities Orm = new PartyDBEntities();
            ViewBag.DishList = Orm.Dishes.ToList();
            return View();
        }
        public ActionResult GuestIndex()
        {
            PartyDBEntities Orm = new PartyDBEntities();
            ViewBag.GuestList = Orm.Guests.ToList();
            return View();
        }

        public ActionResult SaveGuest(Guest addGuest)
        {
            PartyDBEntities Orm = new PartyDBEntities();
            Orm.Guests.Add(addGuest);
            Orm.SaveChanges();
            return RedirectToAction("RsvpComplete", "Home", addGuest);
        }
        public ActionResult SaveDish(Dish addDish)
        {
            PartyDBEntities Orm = new PartyDBEntities();
            Orm.Dishes.Add(addDish);
            Orm.SaveChanges();
            return RedirectToAction("ThankYouForDish", "Home", addDish);
        }

        public ActionResult EditGuest(int GuestID)
        {
            PartyDBEntities Orm = new PartyDBEntities();
            Guest found = Orm.Guests.Find(GuestID);

            return View(found);
        }

        public ActionResult EditDish(int DishID)
        {
            PartyDBEntities Orm = new PartyDBEntities();
            Dish found = Orm.Dishes.Find(DishID);

            return View(found);
        }

        public ActionResult SaveEditGuest(Guest updateGuest)
        {
            PartyDBEntities Orm = new PartyDBEntities();
            Guest oldGuest = Orm.Guests.Find(updateGuest.GuestID);

            oldGuest.FirstName = updateGuest.FirstName;
            oldGuest.LastName = updateGuest.LastName;
            oldGuest.AttendanceDate = updateGuest.AttendanceDate;
            oldGuest.EmailAddress = updateGuest.EmailAddress;
            oldGuest.Guest1 = updateGuest.Guest1;

            Orm.Entry(oldGuest).State = EntityState.Modified;
            Orm.SaveChanges();

            return RedirectToAction("GuestIndex");

        }

        public ActionResult SaveEditDish(Dish updateDish)
        {
            PartyDBEntities Orm = new PartyDBEntities();
            Dish oldDish = Orm.Dishes.Find(updateDish.DishID);

            oldDish.PersonName = updateDish.PersonName;
            oldDish.PhoneNumber = updateDish.PhoneNumber;
            oldDish.DishName = updateDish.DishName;
            oldDish.DishDescription = updateDish.DishDescription;
            oldDish.Option = updateDish.Option;

            Orm.Entry(oldDish).State = EntityState.Modified;
            Orm.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult DeleteGuest(int GuestID)
        {
            PartyDBEntities Orm = new PartyDBEntities();
            Guest found = Orm.Guests.Find(GuestID);

            Orm.Guests.Remove(found);
            Orm.SaveChanges();

            return RedirectToAction("GuestIndex");
        }

        public ActionResult DeleteDish(int DishID)
        {
            PartyDBEntities Orm = new PartyDBEntities();
            Dish found = Orm.Dishes.Find(DishID);

            Orm.Dishes.Remove(found);
            Orm.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}