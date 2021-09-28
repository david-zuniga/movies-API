using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Entities
{
    public class Gender
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Gender Name is required")]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        public List<MoviesGenders> MoviesGenders { get; set; }
    }
}
