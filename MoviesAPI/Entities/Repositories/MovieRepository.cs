using Microsoft.EntityFrameworkCore;
using MoviesAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Entities.Repositories
{
    public class MovieRepository: IMovieRepository
    {
        private readonly ApplicationDbContext context;

        public MovieRepository( ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Movie>> FilterMovies(MoviesFilterDTO moviesFilterDTO)
        {
            var movies = context.Movies
                .Include(x => x.MoviesGenders).ThenInclude(x => x.Gender)
                .Include(x => x.MoviesActors).ThenInclude(x => x.Actor)
                .AsQueryable();
            
            if (!string.IsNullOrEmpty(moviesFilterDTO.Title))
            {
                movies = movies.Where(x => x.Title.Contains(moviesFilterDTO.Title));
            }

            //TODO: Implement these fields as select
            if (!string.IsNullOrEmpty(moviesFilterDTO.Gender))
            {
                movies = movies
                    .Where(x => x.MoviesGenders.Any(y => y.Gender.Name.Contains(moviesFilterDTO.Gender)));
            }

            if (!string.IsNullOrEmpty(moviesFilterDTO.Actor))
            {
                movies = movies
                    .Where(x => x.MoviesActors.Any(y => y.Actor.Name.Contains(moviesFilterDTO.Actor)));
            }

            return await movies.ToListAsync();

        }

        public async Task<List<Movie>> GetAllMovies()
        {
            return await context.Movies.ToListAsync();
        }

        public async Task<Movie> GetById(int id)
        {
            return await context.Movies
                .Include(x => x.MoviesGenders).ThenInclude(x => x.Gender)
                .Include(x => x.MoviesActors).ThenInclude(x => x.Actor)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
