using AutoMapper;
using MoviesAPI.DTOs;
using MoviesAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Utilities
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Movie, MovieDTO>();

            CreateMap<Movie, MovieDTO>()
                .ForMember(x => x.Genders, options => options.MapFrom(MapMoviesGenders))
                .ForMember(x => x.Actors, options => options.MapFrom(MapMoviesActors));
        }


        private List<GenderDTO> MapMoviesGenders(Movie movie, MovieDTO movieDTO)
        {
            var result = new List<GenderDTO>();

            if (movie.MoviesGenders != null)
            {
                foreach (var gender in movie.MoviesGenders)
                {
                    result.Add(new GenderDTO() { Id = gender.GenderId, Name = gender.Gender.Name });
                }    
            }

            return result;
        }

        private List<ActorDTO> MapMoviesActors(Movie movie, MovieDTO movieDTO)
        {
            var result = new List<ActorDTO>();

            if (movie.MoviesActors != null)
            {
                foreach (var actor in movie.MoviesActors)
                {
                    result.Add(new ActorDTO() { Id = actor.ActorId, Name = actor.Actor.Name });
                }
            }

            return result;
        }
    }
}
