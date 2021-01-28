using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<MovieViewModel> GetAllMovies();
        MovieViewModel GetMovieById(int id);
        List<MovieViewModel> SearchMovies(string searchTerm);
        List<MovieViewModel> Delete(int id);
    }
}
