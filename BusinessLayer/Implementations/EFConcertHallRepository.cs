using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
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

        public async Task<ICollection<ConcertHall>> GetAllConcertHalls()
        {
            return await _ctx.ConcertHalls.ToListAsync();
        }

        public async Task<ConcertHall> GetConcertHallById(int Id)
        {
            return await _ctx.ConcertHalls.FirstOrDefaultAsync(c => c.Id == Id);
        }
        public async Task<ConcertHall> GetConcertHallByAddress(string address)
        {
            return await _ctx.ConcertHalls.FirstOrDefaultAsync(c => c.Address == address);
        }

        public Task UpdateConcertHall(ConcertHall concertHall)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
