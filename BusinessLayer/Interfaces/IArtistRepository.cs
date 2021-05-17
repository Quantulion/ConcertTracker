using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IArtistRepository : IDisposable
    {
        Task<ICollection<Artist>> GetAllArtistsAsync();
        Task<Artist> GetArtistByIdAsync(string Id);
        Task<List<Concert>> GetConcertsOfArtistAsync(Artist artist);
        Task<Artist> AddArtistAsync(Artist artist);
        Task UpdateArtistAsync(Artist artist);
    }
}
