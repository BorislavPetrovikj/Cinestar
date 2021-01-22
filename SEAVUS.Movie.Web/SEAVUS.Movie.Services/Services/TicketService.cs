using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Services
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Domain.Models.Movie> _movieRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<Ticket> _ticketService;

        public TicketService(IRepository<Domain.Models.Movie> movieRepository, IUserRepository userRepository, IRepository<Ticket> ticketService)
        {
            _movieRepository = movieRepository;
            _userRepository = userRepository;
            _ticketService = ticketService;
        }
        public int CreateReservation(TicketViewModel model, string userId)
        {
            throw new NotImplementedException();

        }
        public TicketViewModel GetTicketById(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
