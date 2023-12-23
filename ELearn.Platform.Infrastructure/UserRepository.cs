using ELearn.Platform.Domain.Entity;

namespace ELearn.Platform.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly EfDbContext _efDbContext;
        public UserRepository (EfDbContext efDbContext)
        {
            _efDbContext = efDbContext;
        }
        public List<User> GetUsers()
        {
            return _efDbContext.Users.ToList();
        }
        public User AddUser(User user)
        {
             _efDbContext.Users.Add(user);
            _efDbContext.SaveChanges();
            return user;
        }
    }
}