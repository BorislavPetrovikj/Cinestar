using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAVUS.Movie.Domain.Models
{
    public class Seat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int HallId { get; set; }
        public decimal Price { get; set; }
        public int SeatNumber { get; set; }
        public int RowNumber { get; set; }
        public sbyte Available { get; set; }
        public string Type { get; set; }

        public Hall Hall { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
