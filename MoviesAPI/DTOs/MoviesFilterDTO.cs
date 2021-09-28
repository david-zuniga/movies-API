using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.DTOs
{
    public class MoviesFilterDTO
    {
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Actor { get; set; }

    }
}
