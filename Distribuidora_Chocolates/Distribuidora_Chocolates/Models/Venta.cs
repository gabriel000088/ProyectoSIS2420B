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
    }
}
