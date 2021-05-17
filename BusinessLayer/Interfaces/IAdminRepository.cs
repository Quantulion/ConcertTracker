using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IAdminRepository : IDisposable
    {
        Task<ICollection<Admin>> GetAllAdminsAsync();
        Task<Admin> GetAdminByIdAsync(string Id);
        Task<Admin> AddAdminAsync(Admin admin);
    }
}
