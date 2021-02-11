using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAVUS.Movie.Domain.Models
{
    public class Hall
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<Show> Shows { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
