using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IConcertRepository : IDisposable
    {
        Task<IEnumerable<Concert>> GetAllConcerts();
        Task<Concert> GetConcertById(int Id);
        Task UpdateConcert(Concert concert);
        Task<Concert> AddConcert(Concert concert);
    }
}
