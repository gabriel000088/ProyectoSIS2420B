using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora_Chocolates.Models
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        [Required]
        public int NroVenta { get; set; }
        [Required]
        public DateTime fechaVenta { get; set; }

        //Clave foranea
        //Muchas ventas tiene un usuario
        public Usuario Usuario { get; set;}
        //Muchas ventas tiene un cliente
        public Cliente Cliente { get; set; }

        //integridad referencial
        //Un venta genera muchas detalles
        public List<Detalle> Detalle { get; set; }
    }
}
