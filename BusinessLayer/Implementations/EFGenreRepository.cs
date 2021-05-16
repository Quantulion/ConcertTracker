using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class EFGenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFGenreRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public Task<Genre> AddGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        
        public async Task<ICollection<Genre>> GetAllGenres()
        {
            return await _ctx.Genres.ToListAsync();
        }

        public async Task<Genre> GetGenreByName(string name)
        {
            return await _ctx.Genres.FirstOrDefaultAsync(g => g.Name == name);
        }

        public Task UpdateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
