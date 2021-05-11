using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IConcertHallRepository : IDisposable
    {
        Task<ICollection<ConcertHall>> GetAllConcertHalls();
        Task<ConcertHall> GetConcertHallById(int Id);
        Task<ConcertHall> GetConcertHallByAddress(string address);
        Task<List<Concert>> GetConcertsOfConcertHall(ConcertHall concertHall);
        Task<ConcertHall> AddConcertHall(ConcertHall concertHall);
        Task UpdateConcertHall(ConcertHall concertHall);
    }
}
