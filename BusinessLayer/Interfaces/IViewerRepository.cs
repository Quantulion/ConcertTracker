using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IViewerRepository : IDisposable
    {
        Task<ICollection<Viewer>> GetAllViewersAsync();
        Task<Viewer> GetViewerByIdAsync(string Id);
        Task<Genre> AddViewerAsync(Viewer viewer);
        Task UpdateViewerAsync(Viewer viewer);
    }
}
