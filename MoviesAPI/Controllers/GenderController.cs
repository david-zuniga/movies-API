using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/genders")]
    public class GenderController
    {
        public GenderController( )
        {
        }

        [HttpGet]
        public ActionResult<List<Gender>> Get()
        {
            return new List<Gender> { new Gender() { Id = 1, Name = "Comedy " } };
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Gender>> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void Post()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public void Put()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
