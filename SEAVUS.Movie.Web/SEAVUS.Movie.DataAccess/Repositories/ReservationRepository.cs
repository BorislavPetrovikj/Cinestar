using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class ReservationRepository : BaseRepository, IRepository<Reservation>
    {
        public ReservationRepository(MovieDbContext context) : base(context) { }

        public int Delete(int id)
        {
            Reservation reservation = _db.Reservations.SingleOrDefault(x => x.Id == id);
            if (reservation == null)
                return -1;
            _db.Reservations.Remove(reservation);
            int reservationId = _db.SaveChanges();
            return reservationId;
        }

        public IEnumerable<Reservation> GetAll()
        {
            IEnumerable<Reservation> reservations = _db.Reservations
                                                       .Include(x => x.User)
                                                       .ThenInclude(x => x.Reservations)
                                                       .ThenInclude(x=>x.Tickets)
                                                       .Include(x => x.Show)
                                                       .ThenInclude(x => x.Hall)
                                                       .ThenInclude(x => x.Seats);
                                                         
            return reservations;
        }

        public Reservation GetById(int id)
        {
            Reservation reservation = _db.Reservations
                                        .Include(x => x.User)
                                        .ThenInclude(x => x.Reservations)
                                        .ThenInclude(x=>x.Tickets)
                                        .Include(x => x.Seat)
                                        .ThenInclude(x => x.Hall)
                                        .Include(x => x.Show)
                                        .ThenInclude(x => x.Movie)
                                        .SingleOrDefault(x => x.Id == id);

            return reservation;
        }

        public int Insert(Reservation entity)
        {
            _db.Reservations.Add(entity);
            int reservationId = _db.SaveChanges();
            return reservationId;
        }

        public int Update(Reservation entity)
        {
            Reservation reservation = _db.Reservations.SingleOrDefault(x => x.Id == entity.Id);
            if (reservation != null)
                _db.Reservations.Update(entity);
            int reservationId = _db.SaveChanges();
            return reservationId;
        }
    }
}
