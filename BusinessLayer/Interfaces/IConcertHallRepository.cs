using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IConcertHallRepository : IDisposable
    {
        Task<ICollection<ConcertHall>> GetAllConcertHallsAsync();
        Task<ConcertHall> GetConcertHallByIdAsync(int id);
        Task<ConcertHall> GetConcertHallByAddressAsync(string address);
        Task<List<Concert>> GetConcertsOfConcertHallAsync(ConcertHall concertHall);
        Task<ConcertHall> AddConcertHallAsync(ConcertHall concertHall);
        Task UpdateConcertHallAsync(ConcertHall concertHall);
        Task DeleteConcertHallAsync(ConcertHall concertHall);
    }
}
