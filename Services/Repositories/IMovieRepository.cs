using CinemaWebApi.Entities;

namespace CinemaWebApi.Services.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Movie GetMovieDetalis(Guid movieId);
    }
}
