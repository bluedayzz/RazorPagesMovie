using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
        public DbSet<RazorPagesMovie.Models.Goods> Goods { get; set; }
        public DbSet<RazorPagesMovie.Models.Group> Group { get; set; }
        public DbSet<RazorPagesMovie.Models.Item> Item { get; set; }
        public DbSet<RazorPagesMovie.Models.Option> Option { get; set; }
        public DbSet<RazorPagesMovie.Models.Userh> Userh { get; set; }
    }
}
