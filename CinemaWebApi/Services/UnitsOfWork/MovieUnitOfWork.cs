using CinemaWebApi.Contexts;
using CinemaWebApi.Services.Repositories;

namespace CinemaWebApi.Services.UnitsOfWork
{
    public class MovieUnitOfWork : IMovieUnitOfWork
    {
        private readonly MovieContext _context;

        public MovieUnitOfWork(MovieContext context, IMovieUnitOfWork movie , IReviewsRepository reviews)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Movie = (IMovieRepository?)(movie ?? throw new ArgumentNullException(nameof(context)));
            Reviews = reviews ?? throw new ArgumentNullException(nameof(context));
        }

        public IMovieRepository Movie { get; }

        public IReviewsRepository Reviews { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
           _context.Dispose();
        }
    }
}
