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
    public class EFAdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFAdminRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<ICollection<Admin>> GetAllAdmins()
        {
            return await _ctx.Admins.ToListAsync();
        }
        public async Task<Admin> GetAdminById(string id)
        {
            return await _ctx.Admins.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Admin> AddAdmin(Admin admin)
        {
            _ctx.Admins.Add(admin);
            await _ctx.SaveChangesAsync();
            return admin;
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
