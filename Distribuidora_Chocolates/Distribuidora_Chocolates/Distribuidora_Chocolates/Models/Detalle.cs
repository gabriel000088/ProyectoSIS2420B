using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora_Chocolates.Models
{
    public class Detalle
    {
        [Key]
        public int IdDetalle { get; set; }
        [Required]
        public double CostoTotal { get; set; }

        //Clave foranea
        //Muchas detalles tiene una venta
        public Venta Venta { get; set; }

        //Muchos detalles tiene un producto
        public Producto Producto { get; set; }
    }
}
