using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Interfaces
{
    public interface IActorService
    {
        List<MovieCastViewModel> GetAllActors();
        MovieCastViewModel GetActorById(int id);
        void UpdateActors(List<Actor> actors);
    }
}
