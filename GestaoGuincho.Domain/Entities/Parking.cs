using GestaoGuincho.Domain.Validations.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Domain.Entities
{
    public class Parking : Entity
    {
        public string City { get; private set; }
        public int VehiclesCollected { get; private set; }
        public int ReleasedVehicles { get; private set; }
        public ICollection<Vehicle> Vehicles { get; set; }


        public Parking(string city)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(city), "É obrigatório informar a cidade do pátio.");
            DomainExceptionValidation.When(city.Length < 3, "O nome da cidade é inválido.");
            City = city;
        }
    }
}
