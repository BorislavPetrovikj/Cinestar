﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SEAVUS.Movie.Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Domain.Models.Movie> _movieRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public MovieService(IRepository<Domain.Models.Movie> movieRepository, IHostingEnvironment hostingEnvironment)
        {
            _movieRepository = movieRepository;
            _hostingEnvironment = hostingEnvironment;
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
            if (DateTime.TryParse(searchTerm, out var dateTime))
            {
                return movies.Where(x => x.ReleaseDate.ToShortDateString() == dateTime.ToShortDateString()).ToList();
            }

            return movies.Where(m => m.MovieTitle.Contains(searchTerm) ||
                                m.ReleaseDate.ToString().Contains(searchTerm) ||
                                m.Genre.Contains(searchTerm) ||
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
        public void AddNewMovie(MovieViewModel model)
        {
            if (model != null)
            {
                Domain.Models.Movie movie = new Domain.Models.Movie();

                List<Actor> actors = (from a in model.Actors
                                      select new Actor
                                      {
                                          Id = a.Id,
                                          FirstName = a.FirstName,
                                          LastName = a.LastName,
                                          Age = a.Age
                                      }).ToList();

                List<Cast> movieCast = (from a in actors
                                        select new Cast
                                        {
                                            Actor = a,
                                            ActorId = a.Id,
                                            Movie = movie,
                                            MovieId = movie.Id
                                        }).ToList();


                movie.Title = model.MovieTitle;
                movie.Description = model.Description;
                movie.Image = model.Image;
                movie.Genre = model.Genre;
                movie.Director = model.Director;
                movie.Language = model.Language;
                movie.ReleaseDate = model.ReleaseDate;
                movie.Technology = model.Technology;
                movie.MovieCast = movieCast;


                _movieRepository.Insert(movie);
            }
        }
        public void EditMovie(MovieViewModel model)
        {
            if (model != null)
            {
                Domain.Models.Movie movie = _movieRepository.GetAll().Where(x => x.Id == model.Id).SingleOrDefault();

                List<Actor> actors = (from a in model.Actors
                                      select new Actor
                                      {
                                          Id = a.Id,
                                          FirstName = a.FirstName,
                                          LastName = a.LastName,
                                          Age = a.Age
                                      }).ToList();

                List<Cast> movieCast = (from a in actors
                                        select new Cast
                                        {
                                            Actor = a,
                                            ActorId = a.Id,
                                            Movie = movie,
                                            MovieId = movie.Id
                                        }).ToList();

                    movie.Title = model.MovieTitle;
                    movie.Description = model.Description;
                    movie.Image = model.Image;
                    movie.Genre = model.Genre;
                    movie.Director = model.Director;
                    movie.Language = model.Language;
                    movie.ReleaseDate = model.ReleaseDate;
                    movie.Technology = model.Technology;
                    movie.MovieCast = movieCast;

                _movieRepository.Update(movie);
            }
        }
       
    }
}
