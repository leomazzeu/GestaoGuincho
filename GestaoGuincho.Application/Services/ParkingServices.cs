using AutoMapper;
using GestaoGuincho.Application.DTOs;
using GestaoGuincho.Application.Interfaces;
using GestaoGuincho.Domain.Entities;
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

        public async Task<IEnumerable<ParkingDTO>> GetAllAsync()
        {
            var parkings = await _parkingRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ParkingDTO>>(parkings);
        }

        public async Task<ParkingDTO> GetByIdAsync(int id)
        {
            var parking = await _parkingRepository.GetByIdAsync(id);
            return _mapper.Map<ParkingDTO>(parking);
        }

        public async Task CreateAsync(ParkingDTO parkingDTO)
        {
            var parking = _mapper.Map<Parking>(parkingDTO);
            await _parkingRepository.CreateAsync(parking);
        }

        public async Task DeleteAsync(ParkingDTO parkingDTO)
        {
            var parking = _mapper.Map<Parking>(parkingDTO);
            await _parkingRepository.DeleteAsync(parking);
        }

        public async Task UpdateAsync(ParkingDTO parkingDTO)
        {
            var parking = _mapper.Map<Parking>(parkingDTO);
            await _parkingRepository.UpdateAsync(parking);
        }
    }
}
