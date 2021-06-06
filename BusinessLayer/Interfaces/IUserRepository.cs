using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IUserRepository : IDisposable
    {
        Task<User> GetUserByIdAsync(string id);
        Task DeleteUserAsync(User user);
    }
}
