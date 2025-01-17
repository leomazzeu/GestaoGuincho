using GestaoGuincho.Domain.Validations;
using GestaoGuincho.Domain.Validations.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Domain.Entities
{
    public class Vehicle : Entity
    {
        public string Plate { get; private set; }
        public string? ChassisIdentification { get; private set; }
        public bool RealLicensePlate { get; private set; } = true;
        public DateTime EntryDate { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public VehicleType Type { get; private set; }
        public int ParkingId { get; set; }
        public Parking Parking { get; set; }

        public Vehicle(string plate, DateTime entryDate, bool realLicensePlate = true)
        {
            ValidateDomain(plate);
            Plate = plate;
            EntryDate = entryDate;
            RealLicensePlate = realLicensePlate;
        }

        public Vehicle(string plate, DateTime entryDate, string chassi)
        {
            ValidateDomain(plate);
            Plate = plate;
            EntryDate= entryDate;
            ChassisIdentification = chassi;
        }

        public Vehicle(string plate, DateTime entryDate, bool realLicensePlate, string chassi)
        {
            ValidateDomain(plate);
            Plate = plate;
            EntryDate = entryDate;
            ChassisIdentification = chassi;
            RealLicensePlate = realLicensePlate;
        }

        public Vehicle(string plate, DateTime entryDate)
        {
            ValidateDomain(plate);
            Plate = plate;
            EntryDate = entryDate;
        }

        private void ValidateDomain(string plate)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(plate), "É obrigatório informar a placa do veículo.");
            ValidatePlate.Validate(plate);
        }

        public enum VehicleType
        {
            Motorcycle,
            Car,
            Heavy,
            ExtraHeavy
        }
    }
}
