using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora_Chocolates.Vistas
{
    public partial class FrmMenuPrincipal : Form
    {
        string _usuario;
        public FrmMenuPrincipal(string usuario)
        {
            InitializeComponent();
            _usuario= usuario;
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _usuario;
        }
        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
