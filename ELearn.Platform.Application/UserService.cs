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

        public User AddUser(User user)
        {
            var result = this.userRepository.AddUser(user);
            return result;
        }

        public List<User> GetUsers()
        {
            var result = this.userRepository.GetUsers();
            return result;
        }
    }
}
