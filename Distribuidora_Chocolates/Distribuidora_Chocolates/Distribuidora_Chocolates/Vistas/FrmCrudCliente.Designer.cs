namespace Distribuidora_Chocolates.Vistas
{
    partial class FrmCrudCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrudCliente));
            this.dataGridView_cliente = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
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
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.col_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_erase = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).BeginInit();
            this.groupBox_regcliente.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_cliente
            // 
            this.dataGridView_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nom,
            this.col_ap,
            this.col_ci,
            this.col_cel,
            this.col_edit,
            this.col_erase});
            this.dataGridView_cliente.Location = new System.Drawing.Point(278, 87);
            this.dataGridView_cliente.Name = "dataGridView_cliente";
            this.dataGridView_cliente.RowHeadersWidth = 51;
            this.dataGridView_cliente.RowTemplate.Height = 24;
            this.dataGridView_cliente.Size = new System.Drawing.Size(587, 197);
            this.dataGridView_cliente.TabIndex = 13;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(785, 45);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(80, 30);
            this.btn_new.TabIndex = 12;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(699, 45);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(80, 30);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(278, 20);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(304, 21);
            this.lbl_buscar.TabIndex = 10;
            this.lbl_buscar.Text = "Buscar por: Nombre | Apellido | CI";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(278, 48);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(403, 22);
            this.txt_buscar.TabIndex = 9;
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
            this.groupBox_regcliente.Location = new System.Drawing.Point(19, 65);
            this.groupBox_regcliente.Name = "groupBox_regcliente";
            this.groupBox_regcliente.Size = new System.Drawing.Size(222, 219);
            this.groupBox_regcliente.TabIndex = 8;
            this.groupBox_regcliente.TabStop = false;
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(101, 121);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(100, 22);
            this.txt_cel.TabIndex = 11;
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(101, 87);
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(100, 22);
            this.txt_ci.TabIndex = 10;
            // 
            // txt_ap
            // 
            this.txt_ap.Location = new System.Drawing.Point(101, 56);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.Size = new System.Drawing.Size(100, 22);
            this.txt_ap.TabIndex = 9;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(101, 22);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 22);
            this.txt_nom.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(113, 166);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(14, 166);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(90, 28);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_cel
            // 
            this.lbl_cel.AutoSize = true;
            this.lbl_cel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cel.Location = new System.Drawing.Point(22, 120);
            this.lbl_cel.Name = "lbl_cel";
            this.lbl_cel.Size = new System.Drawing.Size(73, 21);
            this.lbl_cel.TabIndex = 5;
            this.lbl_cel.Text = "Celular:";
            // 
            // lbl_ci
            // 
            this.lbl_ci.AutoSize = true;
            this.lbl_ci.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ci.Location = new System.Drawing.Point(61, 88);
            this.lbl_ci.Name = "lbl_ci";
            this.lbl_ci.Size = new System.Drawing.Size(34, 21);
            this.lbl_ci.TabIndex = 4;
            this.lbl_ci.Text = "CI:";
            // 
            // lbl_ap
            // 
            this.lbl_ap.AutoSize = true;
            this.lbl_ap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap.Location = new System.Drawing.Point(12, 56);
            this.lbl_ap.Name = "lbl_ap";
            this.lbl_ap.Size = new System.Drawing.Size(83, 21);
            this.lbl_ap.TabIndex = 3;
            this.lbl_ap.Text = "Apellido:";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(13, 23);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(82, 21);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nombre:";
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes.Location = new System.Drawing.Point(15, 21);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(89, 23);
            this.lbl_clientes.TabIndex = 7;
            this.lbl_clientes.Text = "Clientes";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(882, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 20);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 20);
            this.lblUsuario.Text = "XXXXXXX";
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
            this.col_ci.Width = 90;
            // 
            // col_cel
            // 
            this.col_cel.HeaderText = "Celular";
            this.col_cel.MinimumWidth = 6;
            this.col_cel.Name = "col_cel";
            this.col_cel.Width = 90;
            // 
            // col_edit
            // 
            this.col_edit.HeaderText = "";
            this.col_edit.Image = ((System.Drawing.Image)(resources.GetObject("col_edit.Image")));
            this.col_edit.MinimumWidth = 6;
            this.col_edit.Name = "col_edit";
            this.col_edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_edit.Width = 50;
            // 
            // col_erase
            // 
            this.col_erase.HeaderText = "";
            this.col_erase.Image = ((System.Drawing.Image)(resources.GetObject("col_erase.Image")));
            this.col_erase.MinimumWidth = 6;
            this.col_erase.Name = "col_erase";
            this.col_erase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_erase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_erase.Width = 50;
            // 
            // FrmCrudCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 334);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView_cliente);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.groupBox_regcliente);
            this.Controls.Add(this.lbl_clientes);
            this.Name = "FrmCrudCliente";
            this.Text = "Gestionar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).EndInit();
            this.groupBox_regcliente.ResumeLayout(false);
            this.groupBox_regcliente.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cliente;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.GroupBox groupBox_regcliente;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_ci;
        private System.Windows.Forms.TextBox txt_ap;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_cel;
        private System.Windows.Forms.Label lbl_ci;
        private System.Windows.Forms.Label lbl_ap;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cel;
        private System.Windows.Forms.DataGridViewImageColumn col_edit;
        private System.Windows.Forms.DataGridViewImageColumn col_erase;
    }
}