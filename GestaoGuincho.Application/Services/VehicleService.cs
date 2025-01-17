using AutoMapper;
using GestaoGuincho.Application.DTOs;
using GestaoGuincho.Application.Interfaces;
using GestaoGuincho.Domain.Entities;
using GestaoGuincho.Domain.Interfaces;

namespace GestaoGuincho.Application.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleService(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleDTO>> GetAllAsync()
        {
            var vehicles = await _vehicleRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<VehicleDTO>>(vehicles);
        }

        public async Task<VehicleDTO> GetByIdAsync(int id)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(id);
            return _mapper.Map<VehicleDTO>(vehicle);
        }

        public async Task CreateAsync(VehicleDTO vehicleDTO)
        {
            var vehicle = _mapper.Map<Vehicle>(vehicleDTO);
            await _vehicleRepository.CreateAsync(vehicle);
        }

        public async Task DeleteAsync(VehicleDTO vehicleDTO)
        {
            var vehicle = _mapper.Map<Vehicle>(vehicleDTO);
            await _vehicleRepository.DeleteAsync(vehicle);
        }

        public async Task UpdateAsync(VehicleDTO vehicleDTO)
        {
            var vehicle = _mapper.Map<Vehicle>(vehicleDTO);
            await _vehicleRepository.UpdateAsync(vehicle);
        }
    }
}
