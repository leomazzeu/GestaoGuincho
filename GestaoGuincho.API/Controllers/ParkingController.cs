using GestaoGuincho.Application.DTOs;
using GestaoGuincho.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoGuincho.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService _parkingService;

        public ParkingController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllParkings()
        {
            var parkings = await _parkingService.GetAllAsync();
            return Ok(parkings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetParkingById(int id)
        {
            var parking = await _parkingService.GetByIdAsync(id);
            return Ok(parking);
        }

        [HttpPost]
        public async Task<IActionResult> CreateParking(ParkingDTO parking)
        {
            await _parkingService.CreateAsync(parking);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateParking(ParkingDTO parking)
        {
            await _parkingService.UpdateAsync(parking);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveParking(ParkingDTO parking)
        {
            await _parkingService.DeleteAsync(parking);
            return Ok();
        }
    }
}
