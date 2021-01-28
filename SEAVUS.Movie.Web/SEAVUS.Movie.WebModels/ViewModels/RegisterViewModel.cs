using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please insert first name!")]
        [Display(Name = "Enter first name:")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please insert last name!")]
        [Display(Name = "Enter last name:")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please insert username!")]
        [Display(Name = "Enter username:")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please insert email address!")]
        [Display(Name = "Enter email address:")]
        public string Email { get; set; }

        [Display(Name = "Enter your birthdate:")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Please insert password!")]
        [Display(Name = "Enter password:")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]

        [Display(Name = "Confirm password:")]
        public string ConfirmPassword { get; set; }


    }
}

