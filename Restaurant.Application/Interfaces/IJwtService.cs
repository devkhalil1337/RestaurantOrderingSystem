using Restaurant.Application.Entites;

namespace Restaurant.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
