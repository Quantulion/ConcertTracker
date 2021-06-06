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
            try
            {
                if (artist == null)
                    throw new ArgumentNullException("Cannot get genres of null artist");
                
                var artistsWithGenres = _ctx.Artists.Include(g => g.Genres);
                var artistWithGenres = await artistsWithGenres.FirstOrDefaultAsync(a => a.Id == artist.Id);
                return artistWithGenres.Genres;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<ICollection<Genre>> GetAllGenresAsync()
        {
            try
            {
                return await _ctx.Genres.ToListAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Genre> GetGenreByNameAsync(string name)
        {
            try
            {
                var genre = await _ctx.Genres.FirstOrDefaultAsync(g => g.Name == name);
                
                if (genre == null)
                    throw new ArgumentException($"No genre with name {name} found in the database");

                return genre;
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
