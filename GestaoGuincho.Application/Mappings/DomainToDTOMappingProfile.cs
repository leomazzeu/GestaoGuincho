using AutoMapper;
using GestaoGuincho.Application.DTOs;
using GestaoGuincho.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Parking, ParkingDTO>().ReverseMap();
            CreateMap<Vehicle, VehicleDTO>().ReverseMap();
        }
    }
}
