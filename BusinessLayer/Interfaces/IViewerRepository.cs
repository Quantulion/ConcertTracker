using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IViewerRepository : IDisposable
    {
        Task<ICollection<Viewer>> GetAllViewers();
        Task<Viewer> GetViewerById(string Id);
        Task<Genre> AddViewer(Viewer viewer);
        Task UpdateViewer(Viewer viewer);
    }
}
