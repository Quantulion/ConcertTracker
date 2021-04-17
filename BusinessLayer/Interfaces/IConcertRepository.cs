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
        Task<Concert> AddConcert(Concert concert);
        Task UpdateConcert(Concert concert);
    }
}
