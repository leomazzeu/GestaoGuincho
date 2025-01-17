using GestaoGuincho.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Application.Interfaces
{
    public interface IParkingService
    {
        Task<IEnumerable<ParkingDTO>> GetAllAsync();
        Task<ParkingDTO> GetByIdAsync(int id);
        Task<ParkingDTO> CreateAsync(ParkingDTO parking);
        Task<ParkingDTO> UpdateAsync(ParkingDTO parking);
        Task<ParkingDTO> DeleteAsync(ParkingDTO parking);
    }
}
