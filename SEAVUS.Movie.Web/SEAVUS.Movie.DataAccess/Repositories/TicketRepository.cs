using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class TicketRepository : BaseRepository, IRepository<Ticket>
    {
        public TicketRepository(MovieDbContext context) : base(context) {}
        public int Delete(int id)
        {
            Ticket ticket = _db.Tickets.SingleOrDefault(x => x.Id == id);

            if (ticket != null)
            {
                _db.Tickets.Remove(ticket);
                return _db.SaveChanges();
            }
            else
            {
                return -1;
            }
        }

        public IEnumerable<Ticket> GetAll()
        {
            IEnumerable<Ticket> tickets = _db.Tickets
                                           .Include(x => x.User)
                                           .ThenInclude(x => x.Reservations)
                                           .Include(x => x.Seat)
                                           .ThenInclude(x => x.Hall)
                                           .Include(x => x.Show)
                                           .ThenInclude(x => x.Movie);
            return tickets;
        }

        public Ticket GetById(int id)
        {
            Ticket ticket = _db.Tickets
                            .Include(x => x.User)
                            .ThenInclude(x => x.Reservations)
                            .Include(x => x.Seat)
                            .ThenInclude(x => x.Hall)
                            .Include(x => x.Show)
                            .ThenInclude(x => x.Movie)
                            .SingleOrDefault(x => x.Id == id);
            return ticket;
        }

        public int Insert(Ticket entity)
        {
            _db.Tickets.Add(entity);
            int ticketId = _db.SaveChanges();
            return ticketId;
        }

        public int Update(Ticket entity)
        {
            _db.Tickets.Update(entity);
            int ticketId = _db.SaveChanges();
            return ticketId;
        }
    }
}
