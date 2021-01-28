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
        public IActionResult Movies(string searchTerm)
        {
            ViewData["Search"] = searchTerm;

            List<MovieViewModel> movies = _movieService.SearchMovies(searchTerm).ToList();

            return View(movies);
        }

       public IActionResult Details(int id)
        {
            MovieViewModel movie = _movieService.GetMovieById(id);
            return View(movie);
        }

        public IActionResult MoviePanel()
        {
            List<MovieViewModel> movies = _movieService.GetAllMovies().ToList();
            return View(movies);
        }
    }
}
