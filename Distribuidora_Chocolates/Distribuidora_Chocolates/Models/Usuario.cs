using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora_Chocolates.Models
{
    //La clase tiene que ser publica
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string NombreUs { get; set; }
        [Required]
        public string NombreCompUs { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool EstadoUs { get; set; }
        [Required]
        public string RolUs { get; set; }
        [Required]
        public int CelularUs { get; set; }

        ///integridad referencial
        public List<Venta>Venta { get; set; }
    }
}
