using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Application.DTOs
{
    public class VehicleDTO
    {
        [Required(ErrorMessage = "É obrigatório informar a placa do veículo.")]
        [RegularExpression(@"^[A-Z]{3}-\d{4}$|^[A-Z]{3}\d[A-Z]\d{2}$", ErrorMessage = "A placa deve estar no formato ABC-1234 ou ABC1D23.")]
        public required string Plate { get; set; }
        public string? ChassisIdentification { get; set; }
        public bool RealLicensePlate { get; set; } = true;

        [Required(ErrorMessage = "Informe a data de entrada do veículo no pátio")]
        public required DateTime EntryDate { get; set; }

        public DateTime DepartureDate { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o tipo de veículo.")]
        [Range(0, 4)]
        public int VehicleType { get; set; }
    }
}
