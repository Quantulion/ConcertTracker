using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IGenreRepository : IDisposable
    {
        Task<ICollection<Genre>> GetAllGenres();
        Task<Genre> GetGenreByName(string name);
        Task<Genre> AddGenre(Genre genre);
        Task UpdateGenre(Genre genre);
    }
}
