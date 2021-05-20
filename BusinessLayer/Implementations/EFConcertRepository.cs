using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Collections.Generic;
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

        public async Task<Concert> AddConcertAsync(Concert concert)
        {
            _ctx.Concerts.Add(concert);
            await _ctx.SaveChangesAsync();
            return concert;
        }
        public async Task<Concert> AddArtistToConcertAsync(Artist artist, Concert concert)
        {
            concert.Artists.Add(artist);
            await _ctx.SaveChangesAsync();
            return concert;

        }

        public async Task<Concert> SetConcertHallToConcertAsync(ConcertHall concertHall, Concert concert)
        {
            concert.ConcertHall = concertHall;
            await _ctx.SaveChangesAsync();
            return concert;
        }

        public async Task<ICollection<Concert>> GetAllConcertsAsync()
        {
            return await _ctx.Concerts.ToListAsync();
        }

        public async Task<Concert> GetConcertByIdAsync(int Id)
        {
            return await _ctx.Concerts.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task<Concert> GetConcertByPositionAsync(GoogleMapPosition position)
        {
            return await _ctx.Concerts.FirstOrDefaultAsync(c => c.Position.Lat == position.Lat && c.Position.Lng == position.Lng);
        }

        public async Task<List<Artist>> GetArtistsOfConcertAsync(Concert concert)
        {
            var full = _ctx.Concerts.Include(c => c.Artists);
            var artists = await full.FirstOrDefaultAsync(c => c.Id == concert.Id);
            return artists.Artists;
        }
        public async Task<List<Comment>> GetCommentsOfConcertAsync(Concert concert)
        {
            var full = _ctx.Concerts.Include(c => c.Comments);
            var comments = await full.FirstOrDefaultAsync(c => c.Id == concert.Id);
            return comments.Comments;
        }
        public async Task UpdateConcertAsync(Concert concert)
        {
            _ctx.Concerts.Update(concert);
            await _ctx.SaveChangesAsync();
        }
        public async Task DeleteConcertAsync(Concert concert)
        {
            _ctx.Concerts.Remove(concert);
            await _ctx.SaveChangesAsync();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
