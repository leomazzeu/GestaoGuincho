using GestaoGuincho.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Application.Interfaces
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDTO>> GetAllAsync();
        Task<VehicleDTO> GetByIdAsync(int id);
        Task<VehicleDTO> CreateAsync(VehicleDTO vehicle);
        Task<VehicleDTO> UpdateAsync(VehicleDTO vehicle);
        Task<VehicleDTO> DeleteAsync(VehicleDTO vehicle);
    }
}
