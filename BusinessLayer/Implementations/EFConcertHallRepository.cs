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
        public async Task<ConcertHall> AddConcertHallAsync(ConcertHall concertHall)
        {
            _ctx.ConcertHalls.Add(concertHall);
            await _ctx.SaveChangesAsync();
            return concertHall;
        }

        public async Task<ICollection<ConcertHall>> GetAllConcertHallsAsync()
        {
            return await _ctx.ConcertHalls.ToListAsync();
        }

        public async Task<ConcertHall> GetConcertHallByIdAsync(int Id)
        {
            return await _ctx.ConcertHalls.FirstOrDefaultAsync(c => c.Id == Id);
        }
        public async Task<ConcertHall> GetConcertHallByAddressAsync(string address)
        {
            return await _ctx.ConcertHalls.FirstOrDefaultAsync(c => c.Address == address);
        }

        public async Task<List<Concert>> GetConcertsOfConcertHallAsync(ConcertHall concertHall)
        {
            var full = _ctx.ConcertHalls.Include(c => c.Concerts);
            var concerts = await full.FirstOrDefaultAsync(c => c.Id == concertHall.Id);
            return concertHall.Concerts;
        }

        public async Task UpdateConcertHallAsync(ConcertHall concertHall)
        {
            _ctx.ConcertHalls.Update(concertHall);
            await _ctx.SaveChangesAsync();
        }
        public async Task DeleteConcertHallAsync(ConcertHall concertHall)
        {
            _ctx.ConcertHalls.Remove(concertHall);
            await _ctx.SaveChangesAsync();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
