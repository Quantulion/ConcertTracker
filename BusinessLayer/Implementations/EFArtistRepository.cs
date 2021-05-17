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
    public class EFArtistRepository : IArtistRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFArtistRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<ICollection<Artist>> GetAllArtistsAsync()
        {
            return await _ctx.Artists.ToListAsync();
        }

        public async Task<Artist> GetArtistByIdAsync(string id)
        {
            return await _ctx.Artists.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<Concert>> GetConcertsOfArtistAsync(Artist artist)
        {
            var full = _ctx.Artists.Include(c => c.Concerts);
            var concerts = await full.FirstOrDefaultAsync(c => c.Id == artist.Id);
            return concerts.Concerts;
        }

        public async Task<Artist> AddArtistAsync(Artist artist)
        {
            _ctx.Artists.Add(artist);
            await _ctx.SaveChangesAsync();
            return artist;
        }
        public async Task UpdateArtistAsync(Artist artist)
        {
            _ctx.Artists.Update(artist);
            await _ctx.SaveChangesAsync();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
