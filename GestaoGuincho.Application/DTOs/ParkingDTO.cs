using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Application.DTOs
{
    public class ParkingDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o nome da cidade que consta o pátio.")]
        [Length(3, 50, ErrorMessage = "O nome precisa conter entre 3 e 50 caracteres.")]
        public required string City { get; set; }
    }
}
