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
    public class EFConcertRepository : IConcertRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFConcertRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Concert> AddConcert(Concert concert)
        {
            _ctx.Concerts.Add(concert);
            await _ctx.SaveChangesAsync();
            return concert;
        }
        public async Task<Concert> AddArtistToConcert(Artist artist, Concert concert)
        {
            concert.Artists.Add(artist);
            await _ctx.SaveChangesAsync();
            return concert;

        }
        public async Task<ICollection<Concert>> GetAllConcerts()
        {
            return await _ctx.Concerts.ToListAsync();

        }

        public async Task<Concert> GetConcertById(int Id)
        {
            return await _ctx.Concerts.FirstOrDefaultAsync(c => c.Id == Id);
        }
        public async Task<List<Artist>> GetArtistsOfConcert(Concert concert)
        {
            var full = _ctx.Concerts.Include(c => c.Artists);
            var artists = await full.FirstOrDefaultAsync(c => c.Id == concert.Id);
            return artists.Artists;
        }
        public Task UpdateConcert(Concert concert)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
