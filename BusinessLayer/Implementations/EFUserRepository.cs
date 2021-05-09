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
        public Task<User> AddUser(User user)
        {
            throw new NotImplementedException();
        }
        public Task<ICollection<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(string Id)
        {
            return await _ctx.Users.FirstOrDefaultAsync(f => f.Id == Id);
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
