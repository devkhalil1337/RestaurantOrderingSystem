using Restaurant.Application.Entites;

namespace Restaurant.Application.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }

}
