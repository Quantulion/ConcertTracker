using System;
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
            try
            {
                if(concert == null) 
                    throw new ArgumentNullException("Cannot add null concert");
                
                _ctx.Concerts.Add(concert);
                await _ctx.SaveChangesAsync();
                return concert;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task<Concert> AddArtistToConcertAsync(Artist artist, Concert concert)
        {
            try
            {
                if(artist == null) 
                    throw new ArgumentNullException("Cannot add null artist to concert");
                if(concert == null) 
                    throw new ArgumentNullException("Cannot add artist to null concert");
                
                concert.Artists.Add(artist);
                await _ctx.SaveChangesAsync();
                return concert;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Concert> SetConcertHallToConcertAsync(ConcertHall concertHall, Concert concert)
        {
            try
            {
                if(concertHall == null) 
                    throw new ArgumentNullException("Cannot set null concert hall to concert");
                if(concert == null) 
                    throw new ArgumentNullException("Cannot set concert hall to null concert");
                
                concert.ConcertHall = concertHall;
                await _ctx.SaveChangesAsync();
                return concert;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<ICollection<Concert>> GetAllConcertsAsync()
        {
            try
            {
                return await _ctx.Concerts.ToListAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Concert> GetConcertByIdAsync(int id)
        {
            try
            {
                var concert = await _ctx.Concerts.FirstOrDefaultAsync(c => c.Id == id);
                
                if(concert == null) 
                    throw new ArgumentException($"No concert with ID {id} found in the database");

                return concert;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Concert> GetConcertByPositionAsync(GoogleMapPosition position)
        {
            try
            {
                var concert = await _ctx.Concerts.FirstOrDefaultAsync(c => c.Position.Lat == position.Lat && c.Position.Lng == position.Lng);
                
                if(concert == null) 
                    throw new ArgumentException($"No concert with position {position} found in the database");

                return concert;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<List<Artist>> GetArtistsOfConcertAsync(Concert concert)
        {
            try
            {
                if (concert == null)
                    throw new ArgumentNullException("Cannot get artists of null concert");
                
                var concertsWithArtists = _ctx.Concerts.Include(c => c.Artists);
                var concertWithArtists = await concertsWithArtists.FirstOrDefaultAsync(c => c.Id == concert.Id);
                return concertWithArtists.Artists;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task<List<Comment>> GetCommentsOfConcertAsync(Concert concert)
        {
            try
            {
                if (concert == null)
                    throw new ArgumentNullException("Cannot get comments of null concert");
                
                var concertsWithComments = _ctx.Concerts.Include(c => c.Comments);
                var concertWithComments = await concertsWithComments.FirstOrDefaultAsync(c => c.Id == concert.Id);
                return concertWithComments.Comments;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task UpdateConcertAsync(Concert concert)
        {
            try
            {
                if (concert == null)
                    throw new ArgumentNullException("Cannot update null concert");
                
                _ctx.Concerts.Update(concert);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task DeleteConcertAsync(Concert concert)
        {
            try
            {
                if (concert == null)
                    throw new ArgumentNullException("Cannot delete null concert");
                
                _ctx.Concerts.Remove(concert);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
