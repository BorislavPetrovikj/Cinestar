using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class ShowViewModel
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string HallTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ShowTime { get; set; }
        public List<SeatViewModel> Seats { get; set; }
    }
}
