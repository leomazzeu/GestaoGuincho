using GestaoGuincho.Application.DTOs;
using GestaoGuincho.Application.Interfaces;

namespace GestaoGuincho.Application.Services
{
    public class VehicleService : IVehicleService
    {
        public Task<VehicleDTO> CreateAsync(VehicleDTO vehicle)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleDTO> DeleteAsync(VehicleDTO vehicle)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VehicleDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<VehicleDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleDTO> UpdateAsync(VehicleDTO vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
