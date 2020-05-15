namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-09-29"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "12 Years a Slave",
                    ReleaseDate = DateTime.Parse("2013-08-30"),
                    Genre = "Drama",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Birdman",
                    ReleaseDate = DateTime.Parse("2014-08-27"),
                    Genre = "Black Comedy-Drama",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Moonlight",
                    ReleaseDate = DateTime.Parse("2016-09-02"),
                    Genre = "Drama",
                    Price = 12.99M
                },
                 new Movie
                 {
                     Title = "The Shape of Water",
                     ReleaseDate = DateTime.Parse("2017-08-31"),
                     Genre = "Romantic Dark Fantasy",
                     Price = 12.99M
                 },
                  new Movie
                  {
                      Title = "Green Book",
                      ReleaseDate = DateTime.Parse("2018-09-11"),
                      Genre = "Comedy",
                      Price = 10.99M
                  },
                   new Movie
                   {
                       Title = "Parasite",
                       ReleaseDate = DateTime.Parse("2019-05-21"),
                       Genre = "Black Comedy Thriller",
                       Price = 10.99M
                   }
                );
        }
    }
}
