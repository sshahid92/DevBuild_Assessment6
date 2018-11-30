using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevBuild_Assessment6_PutMeOnTheList.Models
{
    public class Rsvp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsAttending { get; set; }
        public string Date { get; set; }
        public bool IsGuest { get; set; }
        public string GuestFirstName { get; set; }
        public string GuestLastName { get; set; }
    }
}