using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora_Chocolates.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public string NombreCli { get; set; }
        [Required]
        public string ApellidoCli { get; set; }
        [Required]
        public int Ci_Cli { get; set; }
        public int CelularCli { get; set; }

        //Integridad referencial
        //Un cliente tiene muchas ventas
        public List<Venta> Venta { get; set; }
    }
}
