using Distribuidora_Chocolates.Context;
using Distribuidora_Chocolates.Controladores;
using Distribuidora_Chocolates.Vistas;
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
            /*ModelChocolate db= new ModelChocolate();
            var Cliente = db.Cliente.ToList();
            var Detalle = db.Detalle.ToList();
            var Producto = db.Producto.ToList();
            var usuarios = db.Usuario.ToList();
            var Venta = db.Venta.ToList();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = Ing_cuenta.Text;
            string password = Ing_password.Text;

            UsuarioController usuarioController = new UsuarioController();
            bool isLogin = usuarioController.Login(usuario, password);
            if(isLogin == true)
            {
                //pantalla menu principal
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Password incorrecs",
                    "Distribuidora",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void lbl_Cuenta_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
