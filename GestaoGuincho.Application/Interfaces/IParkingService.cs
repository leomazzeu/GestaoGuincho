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
        Task CreateAsync(ParkingDTO parkingDTO);
        Task UpdateAsync(ParkingDTO parkingDTO);
        Task DeleteAsync(ParkingDTO parkingDTO);
    }
}
