using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Interfaces
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAllReservations();
        Reservation GetReservationById(int id);
        int CreateReservation(Reservation reservation, string userId);
        int AddReservation(int showId, int seatId, string userId);
        Reservation GetCurrentReservation(string userId);

    }
}
