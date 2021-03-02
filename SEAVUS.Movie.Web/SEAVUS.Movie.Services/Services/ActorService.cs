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
    public class ActorService : IActorService
    {
        private readonly IRepository<Actor> _actorRepository;

        public ActorService(IRepository<Actor> actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public MovieCastViewModel GetActorById(int id)
        {
            Actor actor  = _actorRepository.GetById(id);

            if (actor != null)
            {
                MovieCastViewModel model = new MovieCastViewModel()
                {
                    Id = actor.Id,
                    FirstName = actor.FirstName,
                    LastName = actor.LastName,
                    Age = actor.Age.Value
                };
                return model;
            }
            else
            {
                throw new Exception($"Actor with id: {id} is not found");
            }
        }
        public List<MovieCastViewModel> GetAllActors()
        {
            List<Actor> actors = _actorRepository.GetAll().ToList();

            List<MovieCastViewModel> actorsList = (from a in actors
                                               select new MovieCastViewModel
                                               {
                                                   Id = a.Id,
                                                   FirstName = a.FirstName,
                                                   LastName = a.LastName,
                                                   Age = a.Age.Value
                                               }).ToList();

            return actorsList;
        }
        public void UpdateActors(Actor actor, MovieViewModel model)
        {
            string modelFirstName = model.Actors.Find(x => x.Id == actor.Id).FirstName;
            string modelLastName = model.Actors.Find(x => x.Id == actor.Id).LastName;
            int modelAge = model.Actors.Find(x => x.Id == actor.Id).Age;

            if (actor.FirstName != modelFirstName ||
                        actor.LastName != modelLastName ||
                        actor.Age != modelAge)
            {
                actor.FirstName = modelFirstName;
                actor.LastName = modelLastName;
                actor.Age = modelAge;
            }
        }

    }
}
