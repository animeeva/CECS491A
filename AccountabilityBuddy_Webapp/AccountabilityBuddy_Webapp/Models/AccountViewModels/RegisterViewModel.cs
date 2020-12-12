using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountabilityBuddy_Webapp.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Grade Level")]
        public int GradeLvl { get; set; }

        [Required]
        [Display(Name = "Security Question1")]
        public string SecurityQuestion1 = "Security Question 1: What was your childhood nickname?";

        [Required]
        [Display(Name = "Security Answer")]
        public string SecurityAnswer1 { get; set; }

        [Required]
        [Display(Name = "Security Question2")]
        public string SecurityQuestion2 = "Security Question 2: What school did you attend for sixth grade?";

        [Required]
        [Display(Name = "Security Answer")]
        public string SecurityAnswer2 { get; set; }

        [Required]
        [Display(Name = "Security Question3")]
        public string SecurityQuestion3 = "Security Question 3: What is the name of a college you applied to but didn't attend?";

        [Required]
        [Display(Name = "Security Answer")]
        public string SecurityAnswer3 { get; set; }

        [Required]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }


        [Required]
        [Display(Name = "City")]
        public string City { get; set; }


        [Required]
        [Display(Name = "State")]
        public string State { get; set; }


        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }




    }
}
