using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IViewerRepository : IDisposable
    {
        Task<IEnumerable<Viewer>> GetAllViewers();
        Task<Viewer> GetViewerById(int Id);
        Task UpdateViewer(Viewer viewer);
        Task<Genre> AddViewer(Viewer viewer);
    }
}
