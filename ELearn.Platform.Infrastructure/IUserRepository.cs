using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearn.Platform.Domain.Entity;

namespace ELearn.Platform.Infrastructure
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User AddUser(User user);
    }
}
