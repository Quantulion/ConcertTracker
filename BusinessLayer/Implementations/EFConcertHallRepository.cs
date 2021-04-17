using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class EFConcertHallRepository : IConcertHallRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFConcertHallRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<ConcertHall> AddConcertHall(ConcertHall concertHall)
        {
            _ctx.ConcertHalls.Add(concertHall);
            await _ctx.SaveChangesAsync();
            return concertHall;
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public async Task<List<ConcertHall>> GetAllConcertHalls()
        {
            return await _ctx.ConcertHalls.ToListAsync();
        }

        public Task<ConcertHall> GetConcertHallById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateConcertHall(ConcertHall concertHall)
        {
            throw new NotImplementedException();
        }
    }
}
