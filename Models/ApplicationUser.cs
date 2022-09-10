using Microsoft.AspNetCore.Identity;
using System;

namespace App.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime NextOfKinName { get; set; }
        public DateTime NextOfKinAddress { get; set; }
        public DateTime NextOfKinPhone { get; set; }
        public DateTime NextOfKinEmail { get; set; }
        public DateTime Relationship { get; set; }
    }
}
