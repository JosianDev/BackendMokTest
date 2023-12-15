
using System.Collections.Generic;
using BackenMokTest.Models;

namespace BackenMokTest.Services
{

    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        User CreateUser(User user);
        User UpdateUser(int id, User user);
        User DeleteUser(int id);
        User GetByUsername(string username);
    }
}
