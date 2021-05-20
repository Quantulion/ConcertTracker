using DataLayer.Entities;
using System;
using System.Collections.Generic;
using Radzen;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IConcertRepository : IDisposable
    {
        Task<ICollection<Concert>> GetAllConcertsAsync();
        Task<Concert> GetConcertByIdAsync(int Id);
        Task<Concert> GetConcertByPositionAsync(GoogleMapPosition position);
        Task<Concert> AddConcertAsync(Concert concert);
        Task<Concert> AddArtistToConcertAsync(Artist artist, Concert concert);
        Task<Concert> SetConcertHallToConcertAsync(ConcertHall concertHall, Concert concert);
        Task<List<Artist>> GetArtistsOfConcertAsync(Concert concert);
        Task<List<Comment>> GetCommentsOfConcertAsync(Concert concert);
        Task UpdateConcertAsync(Concert concert);
        Task DeleteConcertAsync(Concert concert);
    }
}
