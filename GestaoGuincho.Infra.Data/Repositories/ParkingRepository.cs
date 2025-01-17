using GestaoGuincho.Domain.Entities;
using GestaoGuincho.Domain.Interfaces;
using GestaoGuincho.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Infra.Data.Repositories
{
    public class ParkingRepository : IParkingRepository
    {
        private readonly AppDbContext _context;

        public ParkingRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Parking>> GetAllAsync()
        {
            return await _context.Parkings.ToListAsync();
        }

        public async Task<Parking> GetByIdAsync(int? id)
        {
            return await _context.Parkings.FindAsync(id);
        }

        public async Task<Parking> CreateAsync(Parking parking)
        {
            await _context.Parkings.AddAsync(parking);
            await _context.SaveChangesAsync();
            return parking;
        }

        public async Task<Parking> DeleteAsync(Parking parking)
        {
            _context.Parkings.Remove(parking);
            await _context.SaveChangesAsync();
            return parking;
        }

        public async Task<Parking> UpdateAsync(Parking parking)
        {
            _context.Parkings.Update(parking);
            await _context.SaveChangesAsync();
            return parking;
        }
    }
}
