using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<User> GetUserByIdAsync(string id)
        {
            try
            {
                var user = await _ctx.Users.FirstOrDefaultAsync(f => f.Id == id);
                
                if (user == null)
                    throw new ArgumentException($"No user with ID {id} found in the database");

                return user;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task DeleteUserAsync(User user)
        {
            try
            {
                if (user == null)
                    throw new ArgumentNullException("Cannot delete null user");
                
                var usersWithComments = _ctx.Users.Include(c => c.Comments);
                var userWithComments = await usersWithComments.FirstOrDefaultAsync(c => c.Id == user.Id);
                _ctx.Comments.RemoveRange(userWithComments.Comments);
                _ctx.Users.Remove(user);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
