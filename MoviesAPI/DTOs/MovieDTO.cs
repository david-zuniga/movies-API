using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public string Duration { get; set; }

        public string ReleaseDate { get; set; }

        public List<GenderDTO> Genders { get; set; }
        public List<ActorDTO> Actors { get; set; }

    }
}
