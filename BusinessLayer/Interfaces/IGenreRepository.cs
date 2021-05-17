using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IGenreRepository : IDisposable
    {
        Task<ICollection<Genre>> GetAllGenresAsync();
        Task<Genre> GetGenreByNameAsync(string name);
        Task<Genre> AddGenreAsync(Genre genre);
        Task UpdateGenreAsync(Genre genre);
    }
}
