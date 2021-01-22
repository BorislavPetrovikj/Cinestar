using SEAVUS.Movie.DataAccess.Interfaces;
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

            List<MovieViewModel> mappedMovies = new List<MovieViewModel>();

            foreach(var movie in movies)
            {
                MovieViewModel model = new MovieViewModel();

                model.Id = movie.Id;
                model.MovieTitle = movie.Title;
                model.Description = movie.Description;
                model.Image = movie.Image;
                model.Genre = movie.Genre;

                mappedMovies.Add(model);
            }
            return mappedMovies;
        }

        public MovieViewModel GetMovieById(int id)
        {
            Domain.Models.Movie movie = _movieRepository.GetById(id);

            if(movie != null)
            {
                MovieViewModel model = new MovieViewModel();

                model.Id = movie.Id;
                model.MovieTitle = movie.Title;
                model.Description = movie.Description;
                model.Image = movie.Image;
                model.Genre = movie.Genre;
                model.Director = movie.Director;
                model.Language = movie.Language;
                model.ReleaseDate = movie.ReleaseDate;
                model.Technology = movie.Technology;

                return model;

            } else
            {
                throw new Exception($"Product with id: {id} is not found");
            }
        }

        
    }
}
