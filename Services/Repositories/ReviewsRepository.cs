using CinemaWebApi.Contexts;
using CinemaWebApi.Entities;

namespace CinemaWebApi.Services.Repositories
{
    public class ReviewsRepository : Repository<Reviews>, IReviewsRepository
    {
        private readonly MovieContext _context;

        public ReviewsRepository(MovieContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
    