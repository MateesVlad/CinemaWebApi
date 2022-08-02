using CinemaWebApi.Entities;

namespace CinemaWebApi.Services.Repositories
{
    public interface IUserRepository : IRepository<Users>
    {
        IEnumerable<Users> GetUsers();
    }
}
