using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string  Image { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Technology { get; set; }
        public string Language { get; set; }
    }
}
