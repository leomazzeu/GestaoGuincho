using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Domain.Validations.Exceptions
{
    public class InvalidPlateException : Exception
    {
        public InvalidPlateException() : base("A placa do veículo é inválida.") { }

        public InvalidPlateException(string message) : base(message) { }

        public InvalidPlateException(string message, Exception innerException) : base(message, innerException) { }
    }
}
