using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class MovieCastViewModel
    {
        public int Id { get; set; }
        [Display(Name = "First name")]
        [Required(ErrorMessage = "This field is required!")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        [Required(ErrorMessage = "This field is required!")]
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}
