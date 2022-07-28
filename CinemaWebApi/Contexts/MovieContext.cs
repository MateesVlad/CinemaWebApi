using CinemaWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.Contexts
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options) 
        { 

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Movie> Movie { get; set; }

    }
}
