using GestaoGuincho.Domain.Entities;
using GestaoGuincho.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Infra.Data.Repositories
{
    public class ParkingRepository : IParkingRepository
    {
        public Task<Parking> CreateAsync(Parking entity)
        {
            throw new NotImplementedException();
        }

        public Task<Parking> DeleteAsync(Parking entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Parking>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Parking> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Parking> UpdateAsync(Parking entity)
        {
            throw new NotImplementedException();
        }
    }
}
