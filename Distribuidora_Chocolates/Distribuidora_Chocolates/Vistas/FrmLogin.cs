using Distribuidora_Chocolates.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora_Chocolates
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Sirve para crear las clases a la BBDD
            ModelChocolate db= new ModelChocolate();
            var Cliente = db.Cliente.ToList();
            var Detalle = db.Detalle.ToList();
            var Producto = db.Producto.ToList();
            var usuarios = db.Usuario.ToList();
            var Venta = db.Venta.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Cuenta_Click(object sender, EventArgs e)
        {

        }
    }
}
