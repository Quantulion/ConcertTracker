using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IAdminRepository : IDisposable
    {
        Task<List<Admin>> GetAllAdmins();
        Task<Admin> GetAdminById(string Id);
        Task<Admin> AddAdmin(Admin admin);
    }
}
