using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEAVUS.Movie.WebModels.ViewModels
{
    public class ShowViewModel
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public string MovieTitle { get; set; }
        public string HallTitle { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        public DateTime ShowTime { get; set; }
        public List<SeatViewModel> Seats { get; set; }
    }
}
