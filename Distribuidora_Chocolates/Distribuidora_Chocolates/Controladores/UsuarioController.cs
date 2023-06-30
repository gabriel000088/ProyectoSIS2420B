using Distribuidora_Chocolates.Context;
using Distribuidora_Chocolates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora_Chocolates.Controladores
{
    internal class UsuarioController
    {
        //CRUD Y LOGIN
        ModelChocolate _context = new ModelChocolate();
        public bool Login(string Usuario, string password)

            var UsuarioLogin = _context.Usuario.Where(x => x.NombreUs == Usuario && x.Password == password).SingleOrDefault();
    }
}
