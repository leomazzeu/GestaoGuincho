using GestaoGuincho.Domain.Validations.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Domain.Validations
{
    public class ValidateId
    {
        public ValidateId(int id)
        {
            
        }

        public static void When(int id) {

            if (id < 0)
            {
                throw new DomainExceptionValidation("ID inválido!");
            }
        }
    }
}
