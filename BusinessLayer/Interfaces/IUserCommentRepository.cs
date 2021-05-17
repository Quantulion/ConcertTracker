using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace BusinessLayer.Interfaces
{
    public interface IUserCommentRepository : IDisposable
    {
        Task<ICollection<UserComment>> GetAllUserCommentsAsync();
        Task<ICollection<UserComment>> GetUserCommentsByUserAsync(User user);
        Task<UserComment> AddUserCommentAsync(UserComment userComment);
        Task UpdateUserCommentAsync(UserComment userComment);
        Task DeleteUserCommentAsync(UserComment userComment);
    }
}