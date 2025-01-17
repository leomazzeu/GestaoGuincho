using GestaoGuincho.Domain.Entities;
using GestaoGuincho.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Infra.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public Task<Vehicle> CreateAsync(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> DeleteAsync(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> UpdateAsync(Vehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
