using System;
using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
            try
            {
                return await _ctx.Artists.ToListAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Artist> GetArtistByIdAsync(string id)
        {
            try
            {
                var artist = await _ctx.Artists.FirstOrDefaultAsync(f => f.Id == id);
                
                if (artist == null)
                    throw new ArgumentException($"No artist with ID {id} found in the database");

                return artist;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<List<Concert>> GetConcertsOfArtistAsync(Artist artist)
        {
            try
            {
                if (artist == null)
                    throw new ArgumentNullException("Cannot find null artist");
                
                var artistsWithConcerts = _ctx.Artists.Include(c => c.Concerts);
                var artistWithConcerts = await artistsWithConcerts.FirstOrDefaultAsync(c => c.Id == artist.Id);
                return artistWithConcerts.Concerts;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Artist> AddArtistAsync(Artist artist)
        {
            try
            {
                if (artist == null)
                    throw new ArgumentNullException("Cannot add null artist");
                
                _ctx.Artists.Add(artist);
                await _ctx.SaveChangesAsync();
                return artist;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task UpdateArtistAsync(Artist artist)
        {
            try
            {
                if (artist == null)
                    throw new ArgumentNullException("Cannot update null artist");
                
                _ctx.Artists.Update(artist);
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
