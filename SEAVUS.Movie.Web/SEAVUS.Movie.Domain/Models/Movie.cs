using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAVUS.Movie.Domain.Models
{
    public class Movie
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Image { get; set; }
        public string Trailer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Technology { get; set; }
        public string Language { get; set; }

        public ICollection<Cast> MovieCast { get; set; }
        public ICollection<Show> Shows { get; set; }
    }
}
