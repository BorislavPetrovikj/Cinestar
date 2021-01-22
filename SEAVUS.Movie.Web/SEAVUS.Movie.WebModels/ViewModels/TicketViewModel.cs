using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public UserViewModel User { get; set; }
        public MovieViewModel Movie { get; set; }
        public DateTime StartShow { get; set; }
        public DateTime EndShow { get; set; }
        public int TicketNumber { get; set; }
        public List<SeatViewModel> Seats { get; set; }
        public decimal Price => Seats.Sum(s => s.Price);
    }
}
