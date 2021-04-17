using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IConcertHallRepository : IDisposable
    {
        Task<List<ConcertHall>> GetAllConcertHalls();
        Task<ConcertHall> GetConcertHallById(int Id);
        Task<ConcertHall> AddConcertHall(ConcertHall concertHall);
        Task UpdateConcertHall(ConcertHall concertHall);
    }
}
