using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IGenreRepository : IDisposable
    {
        Task<IEnumerable<Genre>> GetAllGenres();
        Task<Genre> GetGenreById(int Id);
        Task<Genre> AddGenre(Genre genre);
        Task UpdateGenre(Genre genre);
    }
}
