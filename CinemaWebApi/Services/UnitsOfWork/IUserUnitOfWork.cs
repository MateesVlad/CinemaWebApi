using CinemaWebApi.Services.Repositories;

namespace CinemaWebApi.Services.UnitsOfWork
{
    public interface IUserUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }

        int Complete();
    }
}
