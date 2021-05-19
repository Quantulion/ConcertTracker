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

        public async Task<ICollection<Genre>> GetGenresOfArtistAsync(Artist artist)
        {
            var full = _ctx.Artists.Include(g => g.Genres);
            var artistWithGenres = await full.FirstOrDefaultAsync(a => a.Id == artist.Id);
            return artistWithGenres.Genres;
        }

        public Task<Genre> AddGenreAsync(Genre genre)
        {
            throw new NotImplementedException();
        }

        
        public async Task<ICollection<Genre>> GetAllGenresAsync()
        {
            return await _ctx.Genres.ToListAsync();
        }

        public async Task<Genre> GetGenreByNameAsync(string name)
        {
            return await _ctx.Genres.FirstOrDefaultAsync(g => g.Name == name);
        }

        public async Task UpdateGenreAsync(Genre genre)
        {
            _ctx.Genres.Update(genre);
            await _ctx.SaveChangesAsync();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
