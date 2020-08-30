using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
			using RazorPagesMovieContext context = new RazorPagesMovieContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<RazorPagesMovieContext>>());
			// Look for any movies.
			if (context.Movie.Any())
			{
				return;   // DB has been seeded
			}

			context.Movie.AddRange(
				new Movie
				{
					Title = "AWhen Harry Met Sally",
					ReleaseDate = DateTime.Parse("1989-2-12"),
					Genre = "Romantic Comedy",
					Price = 7.99M,
					Rating = "R"

				},

				new Movie
				{
					Title = "AGhostbusters ",
					ReleaseDate = DateTime.Parse("1984-3-13"),
					Genre = "Comedy",
					Price = 8.99M,
					Rating = "G"
				},

				new Movie
				{
					Title = "AGhostbusters 2",
					ReleaseDate = DateTime.Parse("1986-2-23"),
					Genre = "Comedy",
					Price = 9.99M,
					Rating = "NA"
				},

				new Movie
				{
					Title = "ARio Bravo",
					ReleaseDate = DateTime.Parse("1959-4-15"),
					Genre = "Western",
					Price = 3.99M,
					Rating = "NA"
				}
			);
			context.SaveChanges();
		}
    }
}