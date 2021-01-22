using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAVUS.Movie.Domain.Models
{
    public class Reservation
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ShowId { get; set; }
        public int SeatId { get; set; }
        public string UserId { get; set; }
        public decimal? Price { get; set; }
        public DateTime ReservationDate { get; set; }
        public Show Show { get; set; }
        public Seat Seat { get; set; }
        public User User { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
