using Microsoft.AspNetCore.Identity;
using System;

namespace App.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime NextOfKinDateOfBirth { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinAddress { get; set; }
        public string NextOfKinPhone { get; set; }
        public string NextOfKinEmail { get; set; }
        public string Relationship { get; set; }
        public string HighestQualification { get; set; }
        public string Instituition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
