using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class ActorRepository : BaseRepository, IRepository<Actor>
    {
        public ActorRepository(MovieDbContext context) : base(context) { }
        public int Delete(int id)
        {
           Actor actor = _db.Actors.SingleOrDefault(x => x.Id == id);
            if (actor == null)
                return -1;
            _db.Actors.Remove(actor);
            int actorId = _db.SaveChanges();
            return actorId;
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
            Actor actor = _db.Actors
                          .Include(x => x.MovieCast)
                          .ThenInclude(x => x.Actor)
                          .SingleOrDefault(x => x.Id == id);
            return actor;
        }

        public int Insert(Actor entity)
        {
            _db.Actors.Add(entity);
            int actorId = _db.SaveChanges();
            return actorId;
        }

        public int Update(Actor entity)
        {
            Actor actor = _db.Actors.SingleOrDefault(x => x.Id == entity.Id);
            if (actor != null)
                //_db.Entry(actor).State = EntityState.Detached;
                _db.Actors.Update(entity);
            int actorId = _db.SaveChanges();
            return actorId;
        }
    }
}
