using ELearn.Platform.Domain.Entity;
using ELearn.Platform.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ELearn.Platform.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User addUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            var result = this.userRepository.GetUsers();
            return result;
        }
    }
}
