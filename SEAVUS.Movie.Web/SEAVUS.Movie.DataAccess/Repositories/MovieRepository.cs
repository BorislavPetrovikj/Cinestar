using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Repositories
{
    public class MovieRepository : BaseRepository, IRepository<Domain.Models.Movie>
    {
        public MovieRepository(MovieDbContext context) : base(context) { }

        public int Delete(int id)
        {
            Domain.Models.Movie movie = _db.Movies.SingleOrDefault(x => x.Id == id);
            if (movie == null)
                return -1;
            _db.Movies.Remove(movie);
            int movieId = _db.SaveChanges();
            return movieId;
        }

        public IEnumerable<Domain.Models.Movie> GetAll()
        {

            IEnumerable<Domain.Models.Movie> movies = _db.Movies
                                                          .Include(x => x.MovieCast)
                                                          .ThenInclude(x => x.Actor)
                                                          .Include(x => x.Shows)
                                                          .ThenInclude(x => x.Movie);
            return movies;
        }

        public Domain.Models.Movie GetById(int id)
        {
            Domain.Models.Movie movie = _db.Movies
                                        .Include(x=>x.MovieCast)
                                        .ThenInclude(x=>x.Actor)
                                        .SingleOrDefault(x => x.Id == id);


            return movie;
        }

        public int Insert(Domain.Models.Movie entity)
        {
            _db.Movies.Add(entity);
            int movieId = _db.SaveChanges();
            return movieId;
        }

        public int Update(Domain.Models.Movie entity)
        {
            Domain.Models.Movie movie = _db.Movies.SingleOrDefault(x => x.Id == entity.Id);
            if (movie != null)
                _db.Movies.Update(entity);
            int movieId = _db.SaveChanges();
            return movieId;
        }
    }
}
