namespace Productos
{
    partial class frm_gestcliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.groupBox_regcliente = new System.Windows.Forms.GroupBox();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.txt_ap = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_cel = new System.Windows.Forms.Label();
            this.lbl_ci = new System.Windows.Forms.Label();
            this.lbl_ap = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.dataGridView_cliente = new System.Windows.Forms.DataGridView();
            this.col_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Rol = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_RolUs = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_regcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Location = new System.Drawing.Point(29, 41);
            this.lbl_clientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(44, 13);
            this.lbl_clientes.TabIndex = 0;
            this.lbl_clientes.Text = "Clientes";
            // 
            // groupBox_regcliente
            // 
            this.groupBox_regcliente.Controls.Add(this.txt_cel);
            this.groupBox_regcliente.Controls.Add(this.txt_ci);
            this.groupBox_regcliente.Controls.Add(this.txt_ap);
            this.groupBox_regcliente.Controls.Add(this.txt_nom);
            this.groupBox_regcliente.Controls.Add(this.btn_cancel);
            this.groupBox_regcliente.Controls.Add(this.btn_Guardar);
            this.groupBox_regcliente.Controls.Add(this.lbl_cel);
            this.groupBox_regcliente.Controls.Add(this.lbl_ci);
            this.groupBox_regcliente.Controls.Add(this.lbl_ap);
            this.groupBox_regcliente.Controls.Add(this.lbl_nom);
            this.groupBox_regcliente.Location = new System.Drawing.Point(32, 84);
            this.groupBox_regcliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_regcliente.Name = "groupBox_regcliente";
            this.groupBox_regcliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_regcliente.Size = new System.Drawing.Size(166, 178);
            this.groupBox_regcliente.TabIndex = 1;
            this.groupBox_regcliente.TabStop = false;
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(82, 98);
            this.txt_cel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(76, 20);
            this.txt_cel.TabIndex = 11;
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(82, 71);
            this.txt_ci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(76, 20);
            this.txt_ci.TabIndex = 10;
            // 
            // txt_ap
            // 
            this.txt_ap.Location = new System.Drawing.Point(82, 46);
            this.txt_ap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.Size = new System.Drawing.Size(76, 20);
            this.txt_ap.TabIndex = 9;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(82, 18);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(76, 20);
            this.txt_nom.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(82, 143);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(56, 19);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(4, 143);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(56, 19);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_cel
            // 
            this.lbl_cel.AutoSize = true;
            this.lbl_cel.Location = new System.Drawing.Point(16, 93);
            this.lbl_cel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cel.Name = "lbl_cel";
            this.lbl_cel.Size = new System.Drawing.Size(42, 13);
            this.lbl_cel.TabIndex = 5;
            this.lbl_cel.Text = "Celular:";
            // 
            // lbl_ci
            // 
            this.lbl_ci.AutoSize = true;
            this.lbl_ci.Location = new System.Drawing.Point(16, 71);
            this.lbl_ci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ci.Name = "lbl_ci";
            this.lbl_ci.Size = new System.Drawing.Size(20, 13);
            this.lbl_ci.TabIndex = 4;
            this.lbl_ci.Text = "CI:";
            // 
            // lbl_ap
            // 
            this.lbl_ap.AutoSize = true;
            this.lbl_ap.Location = new System.Drawing.Point(16, 46);
            this.lbl_ap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ap.Name = "lbl_ap";
            this.lbl_ap.Size = new System.Drawing.Size(47, 13);
            this.lbl_ap.TabIndex = 3;
            this.lbl_ap.Text = "Apellido:";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(16, 23);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(47, 13);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nombre:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(228, 41);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(155, 20);
            this.txt_buscar.TabIndex = 2;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Location = new System.Drawing.Point(228, 24);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(164, 13);
            this.lbl_buscar.TabIndex = 3;
            this.lbl_buscar.Text = "Buscar por: Nombre | Apellido | CI";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(397, 41);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(56, 19);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(458, 41);
            this.btn_new.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(56, 19);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // dataGridView_cliente
            // 
            this.dataGridView_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nom,
            this.col_ap,
            this.col_ci,
            this.col_cel,
            this.col_option});
            this.dataGridView_cliente.Location = new System.Drawing.Point(214, 106);
            this.dataGridView_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_cliente.Name = "dataGridView_cliente";
            this.dataGridView_cliente.RowHeadersWidth = 51;
            this.dataGridView_cliente.RowTemplate.Height = 24;
            this.dataGridView_cliente.Size = new System.Drawing.Size(509, 122);
            this.dataGridView_cliente.TabIndex = 6;
            // 
            // col_nom
            // 
            this.col_nom.HeaderText = "Nombre";
            this.col_nom.MinimumWidth = 6;
            this.col_nom.Name = "col_nom";
            this.col_nom.Width = 125;
            // 
            // col_ap
            // 
            this.col_ap.HeaderText = "Apellido";
            this.col_ap.MinimumWidth = 6;
            this.col_ap.Name = "col_ap";
            this.col_ap.Width = 125;
            // 
            // col_ci
            // 
            this.col_ci.HeaderText = "CI";
            this.col_ci.MinimumWidth = 6;
            this.col_ci.Name = "col_ci";
            this.col_ci.Width = 125;
            // 
            // col_cel
            // 
            this.col_cel.HeaderText = "Celular";
            this.col_cel.MinimumWidth = 6;
            this.col_cel.Name = "col_cel";
            this.col_cel.Width = 125;
            // 
            // col_option
            // 
            this.col_option.HeaderText = "Opciones";
            this.col_option.MinimumWidth = 6;
            this.col_option.Name = "col_option";
            this.col_option.Width = 125;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Rol,
            this.lbl_RolUs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(27, 17);
            this.lbl_Rol.Text = "Rol:";
            // 
            // lbl_RolUs
            // 
            this.lbl_RolUs.Name = "lbl_RolUs";
            this.lbl_RolUs.Size = new System.Drawing.Size(49, 17);
            this.lbl_RolUs.Text = "XXXXXX";
            // 
            // frm_gestcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView_cliente);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.groupBox_regcliente);
            this.Controls.Add(this.lbl_clientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_gestcliente";
            this.Text = "Gestionar Clientes";
            this.groupBox_regcliente.ResumeLayout(false);
            this.groupBox_regcliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.GroupBox groupBox_regcliente;
        private System.Windows.Forms.Label lbl_cel;
        private System.Windows.Forms.Label lbl_ci;
        private System.Windows.Forms.Label lbl_ap;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_ci;
        private System.Windows.Forms.TextBox txt_ap;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dataGridView_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_option;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Rol;
        private System.Windows.Forms.ToolStripStatusLabel lbl_RolUs;
    }
}