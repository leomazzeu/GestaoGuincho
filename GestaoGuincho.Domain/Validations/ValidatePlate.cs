using GestaoGuincho.Domain.Validations.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestaoGuincho.Domain.Validations
{
    public static class ValidatePlate
    {
        public static void Validate(string plate)
        {
            plate = plate.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(plate))
            {
                throw new ArgumentException("A placa informada não é válida.");
            }

            string oldPattern = @"^[A-Z]{3}\d{4}$";
            string newPattern = @"^[A-Z]{3}\d{1}[A-Z]{1}\d{2}$";

            if (!Regex.IsMatch(plate, oldPattern) || !Regex.IsMatch(plate, newPattern))
            {
                throw new InvalidPlateException($"A placa '{plate}' não está em um formato válido.");
            }
        }
    }
}
