using Distribuidora_Chocolates.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Distribuidora_Chocolates.Context
{
    public partial class ModelChocolate : DbContext
    {
        public ModelChocolate()
            : base("name=ModelChocolate")
        {
        }

        //Mapear a la base de Datos
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Detalle> Detalle { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
    }
}
