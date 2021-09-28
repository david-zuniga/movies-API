using MoviesAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Entities.Repositories
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMovies();
        Task<Movie> GetById(int id);
        Task<List<Movie>> FilterMovies(MoviesFilterDTO oviesFilterDTO);

    }
}
