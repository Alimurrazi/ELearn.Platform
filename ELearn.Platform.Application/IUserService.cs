using ELearn.Platform.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Platform.Application
{
    public interface IUserService
    {
        List<User> GetUsers();
        User AddUser(User user);
    }
}
