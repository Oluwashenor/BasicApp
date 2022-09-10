using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Models.ViewModels
{
    public class Profile
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("First Name")]
        public string NextOfKinFirstName { get; set; }
        [DisplayName("Last Name")]
        public string NextOfKinLastName { get; set; }
        [DisplayName("Phone")]
        public string NextOfKinPhone { get; set; }
        [DisplayName("Address")]
        public string NextOfKinAddress { get; set; }
        [DisplayName("Email")]
        public string NextOfKinEmail { get; set; }
        [DisplayName("Date Of Birth")]
        public string NextOfKinDateOfBirth { get; set; }
    }
}
