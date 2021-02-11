using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class ActorRepository : BaseRepository, IRepository<Actor>
    {
        public ActorRepository(MovieDbContext context) : base(context) { }
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetAll()
        {
            IEnumerable<Actor> actors = _db.Actors
                                        .Include(x => x.MovieCast)
                                        .ThenInclude(x => x.Actor);
            return actors;                                    
        }
                                        

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Actor entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Actor entity)
        {
            throw new NotImplementedException();
        }
    }
}
