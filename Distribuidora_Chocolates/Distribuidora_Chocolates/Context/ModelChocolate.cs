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


        
    }
}
