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
    public class VehicleRepository : IVehicleRepository
    {
        private readonly AppDbContext _context;

        public VehicleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            return await _context.Vehicles.AsNoTracking().ToListAsync();
        }

        public async Task<Vehicle> GetByIdAsync(int? id)
        {
            return await _context.Vehicles.FindAsync(id);
        }
        public async Task<Vehicle> CreateAsync(Vehicle vehicle)
        {
            await _context.AddAsync(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle> DeleteAsync(Vehicle vehicle)
        {
            _context.Remove(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle> UpdateAsync(Vehicle vehicle)
        {
            _context.Remove(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }
    }
}
