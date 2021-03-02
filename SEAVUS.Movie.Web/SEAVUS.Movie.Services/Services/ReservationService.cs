using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Services
{
    public class ReservationService : IReservationService
    {

        public int AddReservation(int showId, int seatId, string userId)
        {
            throw new NotImplementedException();
        }

        public int CreateReservation(Reservation reservation, string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            throw new NotImplementedException();
        }

        public Reservation GetCurrentReservation(string userId)
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
