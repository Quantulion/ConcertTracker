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
        public async Task<ICollection<Admin>> GetAllAdminsAsync()
        {
            try
            {
                return await _ctx.Admins.ToListAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task<Admin> GetAdminByIdAsync(string id)
        {
            try
            {
                var admin = await _ctx.Admins.FirstOrDefaultAsync(f => f.Id == id);
                
                if (admin == null)
                    throw new ArgumentException($"No admin with ID {id} found in the database");

                return admin;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Admin> AddAdminAsync(Admin admin)
        {
            try
            {
                if (admin == null)
                    throw new ArgumentNullException("Admin cannot be null");
                
                _ctx.Admins.Add(admin);
                await _ctx.SaveChangesAsync();
                return admin;
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
