using ELearn.Platform.Domain.Entity;

namespace ELearn.Platform.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User>()
        {
            new User {Id = Guid.NewGuid() , UserName = "alimurrazi" , FirstName = "alimur", 
            LastName ="razi"},
            new User {Id = Guid.NewGuid() , UserName = "alimurrazi" , FirstName = "alimur",
            LastName ="razi"}
        };
        public List<User> GetUsers()
        {
            return users;
        }
    }
}