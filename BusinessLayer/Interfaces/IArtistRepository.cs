using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IArtistRepository : IDisposable
    {
        Task<ICollection<Artist>> GetAllArtists();
        Task<Artist> GetArtistById(string Id);
        Task<Artist> AddArtist(Artist artist);
        Task UpdateArtist(Artist artist);
    }
}
