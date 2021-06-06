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
            try
            {
                if (concertHall == null)
                    throw new ArgumentNullException("Cannot add null Concert Hall");
                
                _ctx.ConcertHalls.Add(concertHall);
                await _ctx.SaveChangesAsync();
                return concertHall;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<ICollection<ConcertHall>> GetAllConcertHallsAsync()
        {
            try
            {
                return await _ctx.ConcertHalls.ToListAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<ConcertHall> GetConcertHallByIdAsync(int id)
        {
            try
            {
                var concertHall = await _ctx.ConcertHalls.FirstOrDefaultAsync(c => c.Id == id);
                
                if(concertHall == null) 
                    throw new ArgumentException($"No concert hall with ID {id} found in the database");

                return concertHall;
            }
            catch (Exception e)
            {
                throw;
            }
            
        }
        public async Task<ConcertHall> GetConcertHallByAddressAsync(string address)
        {
            try
            {
                if(address == null) 
                    throw new ArgumentNullException("Address cannot be null");
                
                return await _ctx.ConcertHalls.FirstOrDefaultAsync(c => c.Address == address);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<List<Concert>> GetConcertsOfConcertHallAsync(ConcertHall concertHall)
        {
            try
            {
                if(concertHall == null) 
                    throw new ArgumentNullException("Cannot get concerts of null concert hall");
                
                var concertHallsWithConcerts = _ctx.ConcertHalls.Include(c => c.Concerts);
                var concertHallWithConcerts = await concertHallsWithConcerts.FirstOrDefaultAsync(c => c.Id == concertHall.Id);
                return concertHallWithConcerts.Concerts;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task UpdateConcertHallAsync(ConcertHall concertHall)
        {
            try
            {
                if(concertHall == null) 
                    throw new ArgumentNullException("Cannot update null concert hall");
                
                _ctx.ConcertHalls.Update(concertHall);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task DeleteConcertHallAsync(ConcertHall concertHall)
        {
            try
            {
                if(concertHall == null) 
                    throw new ArgumentNullException("Cannot delete null concert hall");
                
                _ctx.ConcertHalls.Remove(concertHall);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
