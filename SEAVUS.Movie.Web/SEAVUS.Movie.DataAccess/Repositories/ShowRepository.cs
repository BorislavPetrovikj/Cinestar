using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq
using System.Text

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class ShowRepository : BaseRepository, IRepository<Show>
    {
        public ShowRepository(MovieDbContext context) : base(context) { }

        public int Delete(int id)
        {
            Show show = _db.Shows.SingleOrDefault(x => x.Id == id);
            if (show == null)
                return -1;
            _db.Shows.Remove(show);
            int showId = _db.SaveChanges();
            return showId;
        }

        public IEnumerable<Show> GetAll()
        {
            IEnumerable<Show> shows = _db.Shows
                                         .Include(x => x.Hall)
                                         .ThenInclude(x => x.Shows)
                                         .ThenInclude(x => x.Movie);
                                        
            return shows;
        }

        public Show GetById(int id)
        {
            Show show = _db.Shows
                           .Include(x => x.Hall)
                           .ThenInclude(x => x.Shows)
                           .ThenInclude(x => x.Movie)
                           .SingleOrDefault(x => x.Id == id);

            return show;
        }

        public int Insert(Show entity)
        {
            _db.Shows.Add(entity);
            int showId = _db.SaveChanges();
            return showId;
        }

        public int Update(Show entity)
        {
            Show show = _db.Shows.SingleOrDefault(x => x.Id == entity.Id);
            if (show != null)
                _db.Shows.Update(entity);
            int showId = _db.SaveChanges();
            return showId;
        }
    }
}
