using AutoMapper;
using GestaoGuincho.Application.DTOs;
using GestaoGuincho.Application.Interfaces;
using GestaoGuincho.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Application.Services
{
    public class ParkingServices : IParkingService
    {
        private readonly IParkingRepository _parkingRepository;
        private readonly IMapper _mapper;

        public ParkingServices(IParkingRepository parkingRepository, IMapper mapper)
        {
            _parkingRepository = parkingRepository;
            _mapper = mapper;
        }

        public Task<ParkingDTO> CreateAsync(ParkingDTO parking)
        {
            throw new NotImplementedException();
        }

        public Task<ParkingDTO> DeleteAsync(ParkingDTO parking)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ParkingDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ParkingDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ParkingDTO> UpdateAsync(ParkingDTO parking)
        {
            throw new NotImplementedException();
        }
    }
}
