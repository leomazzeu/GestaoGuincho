using GestaoGuincho.Application.Interfaces;
using GestaoGuincho.Application.Mappings;
using GestaoGuincho.Application.Services;
using GestaoGuincho.Domain.Interfaces;
using GestaoGuincho.Infra.Data.Context;
using GestaoGuincho.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(AppDbContext)
                .Assembly.FullName)));


            services.AddScoped<IParkingRepository, ParkingRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();

            services.AddScoped<IParkingService, ParkingServices>();
            services.AddScoped<IVehicleService, VehicleService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
