using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Movie Title")]
        [Required(ErrorMessage = "This field is required!")]
        public string MovieTitle { get; set; }
        public string  Image { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Director { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Technology { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Language { get; set; }
        public List<MovieCastViewModel> Actors { get; set; }
        public List <ShowViewModel> Shows { get; set; }
    }
}
