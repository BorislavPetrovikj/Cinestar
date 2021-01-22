using Microsoft.AspNetCore.Mvc;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEAVUS.Movie.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Movies()
        {
            List<MovieViewModel> movies = _movieService.GetAllMovies().ToList();

            return View(movies);
        }

       public IActionResult Details(int id)
        {
            MovieViewModel movie = _movieService.GetMovieById(id);
            return View(movie);
        }
    }
}
