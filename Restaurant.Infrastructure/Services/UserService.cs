using Restaurant.Application.Entites;
using Restaurant.Application.Interfaces;

namespace Restaurant.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new()
    {
        new User { Id = 1, Username = "admin", Password = "1234", Role = "Admin" },
        new User { Id = 2, Username = "user", Password = "1234", Role = "User" }
    };

        public User Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }

}
