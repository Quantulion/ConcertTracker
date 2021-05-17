using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class EFUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFUserRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public Task<User> AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }
        public Task<ICollection<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(string Id)
        {
            return await _ctx.Users.FirstOrDefaultAsync(f => f.Id == Id);
        }

        public Task UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteUserAsync(User user)
        {
            var full = _ctx.Users.Include(c => c.Comments);
            var comments = await full.FirstOrDefaultAsync(c => c.Id == user.Id);
            _ctx.Comments.RemoveRange(comments.Comments);
            _ctx.Users.Remove(user);
            await _ctx.SaveChangesAsync();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
