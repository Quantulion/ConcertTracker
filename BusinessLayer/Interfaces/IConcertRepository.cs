using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IConcertRepository : IDisposable
    {
        Task<ICollection<Concert>> GetAllConcerts();
        Task<Concert> GetConcertById(int Id);
        Task<Concert> AddConcert(Concert concert);
        Task<Concert> AddArtistToConcert(Artist artist, Concert concert);
        Task<List<Artist>> GetArtistsOfConcert(Concert concert);
        Task UpdateConcert(Concert concert);
    }
}
