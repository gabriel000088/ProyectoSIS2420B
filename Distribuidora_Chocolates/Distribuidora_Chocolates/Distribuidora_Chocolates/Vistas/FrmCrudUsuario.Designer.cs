namespace Distribuidora_Chocolates.Vistas
{
    partial class FrmCrudUsuario
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView_usuario = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.groupBox_regusuario = new System.Windows.Forms.GroupBox();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.txt_paswrd = new System.Windows.Forms.TextBox();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_cel = new System.Windows.Forms.Label();
            this.lbl_paswrd = new System.Windows.Forms.Label();
            this.lbl_cuenta = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_regusuario = new System.Windows.Forms.Label();
            this.lbl_est = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.ComboBox_est = new System.Windows.Forms.ComboBox();
            this.comboBox_rol = new System.Windows.Forms.ComboBox();
            this.col_cuen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_erase = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuario)).BeginInit();
            this.groupBox_regusuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1046, 26);
            this.statusStrip1.TabIndex = 22;
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
            // dataGridView_usuario
            // 
            this.dataGridView_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cuen,
            this.col_pass,
            this.col_nom,
            this.col_est,
            this.col_cel,
            this.col_rol,
            this.col_edit,
            this.col_erase});
            this.dataGridView_usuario.Location = new System.Drawing.Point(278, 78);
            this.dataGridView_usuario.Name = "dataGridView_usuario";
            this.dataGridView_usuario.RowHeadersWidth = 51;
            this.dataGridView_usuario.RowTemplate.Height = 24;
            this.dataGridView_usuario.Size = new System.Drawing.Size(756, 307);
            this.dataGridView_usuario.TabIndex = 21;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(920, 40);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 20;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(839, 40);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Location = new System.Drawing.Point(278, 19);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(260, 16);
            this.lbl_buscar.TabIndex = 18;
            this.lbl_buscar.Text = "Buscar por: Username | Nombre Completo";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(278, 41);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(542, 22);
            this.txt_buscar.TabIndex = 17;
            // 
            // groupBox_regusuario
            // 
            this.groupBox_regusuario.Controls.Add(this.comboBox_rol);
            this.groupBox_regusuario.Controls.Add(this.ComboBox_est);
            this.groupBox_regusuario.Controls.Add(this.lbl_rol);
            this.groupBox_regusuario.Controls.Add(this.lbl_est);
            this.groupBox_regusuario.Controls.Add(this.txt_cel);
            this.groupBox_regusuario.Controls.Add(this.txt_paswrd);
            this.groupBox_regusuario.Controls.Add(this.txt_cuenta);
            this.groupBox_regusuario.Controls.Add(this.txt_nom);
            this.groupBox_regusuario.Controls.Add(this.btn_cancel);
            this.groupBox_regusuario.Controls.Add(this.btn_Guardar);
            this.groupBox_regusuario.Controls.Add(this.lbl_cel);
            this.groupBox_regusuario.Controls.Add(this.lbl_paswrd);
            this.groupBox_regusuario.Controls.Add(this.lbl_cuenta);
            this.groupBox_regusuario.Controls.Add(this.lbl_nom);
            this.groupBox_regusuario.Location = new System.Drawing.Point(13, 56);
            this.groupBox_regusuario.Name = "groupBox_regusuario";
            this.groupBox_regusuario.Size = new System.Drawing.Size(222, 329);
            this.groupBox_regusuario.TabIndex = 16;
            this.groupBox_regusuario.TabStop = false;
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(109, 121);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(100, 22);
            this.txt_cel.TabIndex = 11;
            // 
            // txt_paswrd
            // 
            this.txt_paswrd.Location = new System.Drawing.Point(109, 87);
            this.txt_paswrd.Name = "txt_paswrd";
            this.txt_paswrd.Size = new System.Drawing.Size(100, 22);
            this.txt_paswrd.TabIndex = 10;
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Location = new System.Drawing.Point(109, 56);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(100, 22);
            this.txt_cuenta.TabIndex = 9;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(12, 206);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(184, 22);
            this.txt_nom.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(115, 280);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(12, 280);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_cel
            // 
            this.lbl_cel.AutoSize = true;
            this.lbl_cel.Location = new System.Drawing.Point(22, 115);
            this.lbl_cel.Name = "lbl_cel";
            this.lbl_cel.Size = new System.Drawing.Size(52, 16);
            this.lbl_cel.TabIndex = 5;
            this.lbl_cel.Text = "Celular:";
            // 
            // lbl_paswrd
            // 
            this.lbl_paswrd.AutoSize = true;
            this.lbl_paswrd.Location = new System.Drawing.Point(22, 87);
            this.lbl_paswrd.Name = "lbl_paswrd";
            this.lbl_paswrd.Size = new System.Drawing.Size(70, 16);
            this.lbl_paswrd.TabIndex = 4;
            this.lbl_paswrd.Text = "Password:";
            // 
            // lbl_cuenta
            // 
            this.lbl_cuenta.AutoSize = true;
            this.lbl_cuenta.Location = new System.Drawing.Point(22, 56);
            this.lbl_cuenta.Name = "lbl_cuenta";
            this.lbl_cuenta.Size = new System.Drawing.Size(52, 16);
            this.lbl_cuenta.TabIndex = 3;
            this.lbl_cuenta.Text = "Cuenta:";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(9, 187);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(120, 16);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nombre Completo:";
            // 
            // lbl_regusuario
            // 
            this.lbl_regusuario.AutoSize = true;
            this.lbl_regusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regusuario.Location = new System.Drawing.Point(20, 23);
            this.lbl_regusuario.Name = "lbl_regusuario";
            this.lbl_regusuario.Size = new System.Drawing.Size(161, 25);
            this.lbl_regusuario.TabIndex = 15;
            this.lbl_regusuario.Text = "Registrar Usuario";
            // 
            // lbl_est
            // 
            this.lbl_est.AutoSize = true;
            this.lbl_est.Location = new System.Drawing.Point(25, 152);
            this.lbl_est.Name = "lbl_est";
            this.lbl_est.Size = new System.Drawing.Size(53, 16);
            this.lbl_est.TabIndex = 12;
            this.lbl_est.Text = "Estado:";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Location = new System.Drawing.Point(25, 245);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(31, 16);
            this.lbl_rol.TabIndex = 13;
            this.lbl_rol.Text = "Rol:";
            // 
            // ComboBox_est
            // 
            this.ComboBox_est.FormattingEnabled = true;
            this.ComboBox_est.Location = new System.Drawing.Point(109, 149);
            this.ComboBox_est.Name = "ComboBox_est";
            this.ComboBox_est.Size = new System.Drawing.Size(100, 24);
            this.ComboBox_est.TabIndex = 21;
            // 
            // comboBox_rol
            // 
            this.comboBox_rol.FormattingEnabled = true;
            this.comboBox_rol.Location = new System.Drawing.Point(88, 242);
            this.comboBox_rol.Name = "comboBox_rol";
            this.comboBox_rol.Size = new System.Drawing.Size(121, 24);
            this.comboBox_rol.TabIndex = 22;
            // 
            // col_cuen
            // 
            this.col_cuen.HeaderText = "Cuenta";
            this.col_cuen.MinimumWidth = 6;
            this.col_cuen.Name = "col_cuen";
            this.col_cuen.Width = 95;
            // 
            // col_pass
            // 
            this.col_pass.HeaderText = "Password";
            this.col_pass.MinimumWidth = 6;
            this.col_pass.Name = "col_pass";
            this.col_pass.Width = 90;
            // 
            // col_nom
            // 
            this.col_nom.HeaderText = "Nombre Completo";
            this.col_nom.MinimumWidth = 6;
            this.col_nom.Name = "col_nom";
            this.col_nom.Width = 125;
            // 
            // col_est
            // 
            this.col_est.HeaderText = "Estado";
            this.col_est.MinimumWidth = 6;
            this.col_est.Name = "col_est";
            this.col_est.Width = 95;
            // 
            // col_cel
            // 
            this.col_cel.HeaderText = "Celular";
            this.col_cel.MinimumWidth = 6;
            this.col_cel.Name = "col_cel";
            this.col_cel.Width = 90;
            // 
            // col_rol
            // 
            this.col_rol.HeaderText = "User Rol";
            this.col_rol.MinimumWidth = 6;
            this.col_rol.Name = "col_rol";
            this.col_rol.Width = 95;
            // 
            // col_edit
            // 
            this.col_edit.HeaderText = "";
            this.col_edit.MinimumWidth = 6;
            this.col_edit.Name = "col_edit";
            this.col_edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_edit.Width = 50;
            // 
            // col_erase
            // 
            this.col_erase.HeaderText = "";
            this.col_erase.MinimumWidth = 6;
            this.col_erase.Name = "col_erase";
            this.col_erase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_erase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_erase.Width = 50;
            // 
            // FrmCrudUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView_usuario);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.groupBox_regusuario);
            this.Controls.Add(this.lbl_regusuario);
            this.Name = "FrmCrudUsuario";
            this.Text = "Gestionar Usuario";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuario)).EndInit();
            this.groupBox_regusuario.ResumeLayout(false);
            this.groupBox_regusuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.DataGridView dataGridView_usuario;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.GroupBox groupBox_regusuario;
        private System.Windows.Forms.ComboBox comboBox_rol;
        private System.Windows.Forms.ComboBox ComboBox_est;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.Label lbl_est;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_paswrd;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_cel;
        private System.Windows.Forms.Label lbl_paswrd;
        private System.Windows.Forms.Label lbl_cuenta;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_regusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_est;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rol;
        private System.Windows.Forms.DataGridViewImageColumn col_edit;
        private System.Windows.Forms.DataGridViewImageColumn col_erase;
    }
}