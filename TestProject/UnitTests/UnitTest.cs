using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoviesAPI.Controllers;
using MoviesAPI.Entities;
using MoviesAPI.Entities.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Tests;

namespace TestProject.UnitTests
{
    [TestClass]
    public class UnitTest: BaseTests
    {
        [TestMethod]
        public async Task GetAllMovies()
        {
            var db = Guid.NewGuid().ToString();
            var context = BuildContext(db);

            context.Movies.Add(new Movie() { Title = "Movie 1" } );
            context.Movies.Add(new Movie() { Title = "Movie 2" });

            await context.SaveChangesAsync();

            var repo = new MovieRepository(context);
            var movies = await repo.GetAllMovies();

            Assert.IsTrue(movies.Count > 0);
            Assert.IsTrue(movies.Count() == 2);

        }

        [TestMethod]
        public async Task GetMovieById()
        {
            var db = Guid.NewGuid().ToString();
            var context = BuildContext(db);

            context.Movies.Add(new Movie() { Id = 1, Title = "Movie 1" });
            context.Movies.Add(new Movie() { Id = 2, Title = "Movie 2" });

            await context.SaveChangesAsync();

            var repo = new MovieRepository(context);
            var movie = await repo.GetById(1);

            Assert.AreEqual(movie.Id, 1);
        }
    }
}
