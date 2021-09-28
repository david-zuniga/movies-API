using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Entities.Repositories;
using MoviesAPI.Utilities;
using NetTopologySuite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Tests
{
    public class BaseTests
    {
        protected ApplicationDbContext BuildContext(string db)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(db).Options;

            var dbContext = new ApplicationDbContext(options);
            return dbContext;
        }
    }
}
