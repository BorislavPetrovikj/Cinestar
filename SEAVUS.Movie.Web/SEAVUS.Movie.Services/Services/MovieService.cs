using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAVUS.Movie.Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Domain.Models.Movie> _movieRepository;

        public MovieService(IRepository<Domain.Models.Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IEnumerable<MovieViewModel> GetAllMovies()
        {
            List<Domain.Models.Movie> movies = _movieRepository.GetAll().ToList();

            List<MovieViewModel> moviesList = (from m in movies
                              select new MovieViewModel
                              {
                                  Id = m.Id,
                                  MovieTitle = m.Title,
                                  Description = m.Description,
                                  Director = m.Director,
                                  ReleaseDate = m.ReleaseDate,
                                  Image = m.Image,
                                  Genre = m.Genre
                              }).ToList();
          
            return moviesList;
        }
        public MovieViewModel GetMovieById(int id)
        {
            Domain.Models.Movie movie = _movieRepository.GetById(id);

            List<Actor> movieActors = movie.MovieCast.Select(x => x.Actor).ToList();

            List<MovieCastViewModel> actorsList = (from a in movieActors
                                                   select new MovieCastViewModel
                                                   {
                                                       Id = a.Id,
                                                       FirstName = a.FirstName,
                                                       LastName = a.LastName
                                                   }).ToList();
            if (movie != null)
            {
                MovieViewModel model = new MovieViewModel()
                {
                    Id = movie.Id,
                    MovieTitle = movie.Title,
                    Description = movie.Description,
                    Image = movie.Image,
                    Genre = movie.Genre,
                    Director = movie.Director,
                    Language = movie.Language,
                    ReleaseDate = movie.ReleaseDate,
                    Technology = movie.Technology,
                    Actors = actorsList
                };

                return model;

            } else
            {
                throw new Exception($"Product with id: {id} is not found");
            }
        }

        public List<MovieViewModel> SearchMovies(string searchTerm)
        {
            List<MovieViewModel> movies = GetAllMovies().ToList();
            if (string.IsNullOrEmpty(searchTerm))
            {
                return movies;
            }

            return movies.Where(m => m.MovieTitle.Contains(searchTerm) ||
                                m.Genre.Contains(searchTerm) ||
                                m.Director.Contains(searchTerm) ||
                                m.ReleaseDate.Date.ToString().Contains(searchTerm) ||
                                m.Director.Contains(searchTerm)).ToList();
        }

        public List<MovieViewModel> Delete(int id)
        {
            int movieId = _movieRepository.Delete(id);
            List<MovieViewModel> movies = GetAllMovies().ToList();

            if (movieId == -1)
                throw new Exception("Movie not found!");
            return movies;
        }
    }
}
