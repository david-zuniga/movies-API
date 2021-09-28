﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Entities
{
    public class MoviesGenders
    {
        public int MovieId { get; set; }
        public int GenderId { get; set; }
        public Movie Movie { get; set; }
        public Gender Gender { get; set; }
    }
}
