using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Entities
{
    public class Actor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Actor Name is required")]
        [StringLength(maximumLength: 250)]
        public string Name { get; set; }

        public List<MoviesActors> MoviesActors { get; set; }

    }
}
