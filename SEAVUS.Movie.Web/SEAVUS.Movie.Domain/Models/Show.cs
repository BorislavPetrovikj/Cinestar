using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAVUS.Movie.Domain.Models
{
    public class Show
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ShowTime { get; set; }
        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
