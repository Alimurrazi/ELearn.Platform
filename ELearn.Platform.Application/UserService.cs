using ELearn.Platform.Application.Dtos.User;
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

        public User AddUser(AddUserDto user)
        {
            User newUser = new User() { UserId = Guid.NewGuid(),FirstName= user.FirstName, LastName = user.LastName, UserName = user.UserName };
            var result = this.userRepository.AddUser(newUser);
            return result;
        }

        public List<User> GetUsers()
        {
            var result = this.userRepository.GetUsers();
            return result;
        }
    }
}
