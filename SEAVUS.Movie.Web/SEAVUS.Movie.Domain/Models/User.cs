using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Domain.Models
{
    public class User : IdentityUser
    {
        public DateTime? BirthDate { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
