using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; // DB hhas been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Soul",
                        ReleaseDate = DateTime.Parse("2020-2-12"),
                        Genre = "Animation",
                        Price = 10.3M,
                        Rating = "A"
                    },
                    new Movie
                    {
                        Title = "Once Upon a Time in Hollywood",
                        ReleaseDate = DateTime.Parse("2019-6-26"),
                        Genre = "Drama",
                        Price = 7.4M,
                        Rating = "D"
                    },
                    new Movie
                    {
                        Title = "Titanic",
                        ReleaseDate = DateTime.Parse("1997-12-19"),
                        Genre = "Drama",
                        Price = 20.18M,
                        Rating = "D"
                    },
                    new Movie
                    {
                        Title = "Disney's Frozen",
                        ReleaseDate = DateTime.Parse("2000-3-5"),
                        Genre = "Disney",
                        Price = 3.06M,
                        Rating = "C"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
