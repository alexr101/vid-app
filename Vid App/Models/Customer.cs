using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vid_App.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isSubscribedToNewsletter { get; set; }
        public int Age { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; } // foreign key

    }
}