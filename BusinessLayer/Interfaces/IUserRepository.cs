using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IUserRepository : IDisposable
    {
        Task<ICollection<User>> GetAllUsers();
        Task<User> GetUserById(string Id);
        Task<User> AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);
    }
}
