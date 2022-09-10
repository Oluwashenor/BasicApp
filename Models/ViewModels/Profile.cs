using System;
using System.Collections.Generic;
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
        
    }

    public class DependentViewModel
    {
        [DisplayName("Name")]
        public string NextOfKinName { get; set; }
        [DisplayName("Last Name")]
        public string NextOfKinPhone { get; set; }
        [DisplayName("Address")]
        public string NextOfKinAddress { get; set; }
        [DisplayName("Email")]
        public string NextOfKinEmail { get; set; }
        [DisplayName("Date Of Birth")]
        public DateTime NextOfKinDateOfBirth { get; set; }
    }

    public class EducationViewModel
    {
        public string Education { get; set; }
        public string Instituition { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
    }
}
