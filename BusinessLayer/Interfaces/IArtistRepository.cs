using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IArtistRepository : IDisposable
    {
        Task<List<Artist>> GetAllArtists();
        Task<Artist> GetArtistById(int Id);
        Task UpdateArtist(Artist artist);
        Task<Artist> AddArtist(Artist artist);
    }
}
