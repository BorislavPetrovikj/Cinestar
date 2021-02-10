using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Interfaces
{
    public interface ITicketService
    {
        TicketViewModel GetMovieTicketById(int id, string userId);
        int CreateReservation(TicketViewModel ticket, string userId);


    }
}
