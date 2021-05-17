using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;

namespace BusinessLayer.Implementations
{
    public class EFUserCommentRepository : IUserCommentRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFUserCommentRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public Task<ICollection<UserComment>> GetAllUserCommentsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<UserComment>> GetUserCommentsByUserAsync(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserComment> AddUserCommentAsync(UserComment userComment)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateUserCommentAsync(UserComment userComment)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteUserCommentAsync(UserComment userComment)
        {
            throw new System.NotImplementedException();
        }
        public void Dispose()
        {
             throw new System.NotImplementedException();
        }
    }
}