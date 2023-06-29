using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora_Chocolates.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public int CantidadProd { get; set; }
        [Required]
        public bool EstadoProd { get; set; }
        [Required]
        public string MarcaProd { get; set; }
        [Required]
        public string NombreProd { get; set; }
        [Required]
        public DateTime FechaCompra { get; set; }
        [Required]
        public double PrecioCompraProd { get; set; }
        [Required]
        public double PrecioVentaProd { get; set; }
    }
}
