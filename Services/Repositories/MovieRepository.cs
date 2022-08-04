using CinemaWebApi.Contexts;
using CinemaWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.Services.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Movie GetMovieDetalis(Guid movieId)
        {
            return _context.Movie
                .Where(m => m.ID == movieId)
                .Include(m => m.NrRivews)
                .FirstOrDefault();
        }
    }
}
