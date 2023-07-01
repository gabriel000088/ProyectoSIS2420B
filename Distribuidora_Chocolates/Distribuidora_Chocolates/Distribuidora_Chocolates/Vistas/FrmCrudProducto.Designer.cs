namespace Distribuidora_Chocolates.Vistas
{
    partial class FrmCrudProducto
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
            this.dataGrid_producto = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_registrar = new System.Windows.Forms.Label();
            this.groupBox_regproducto = new System.Windows.Forms.GroupBox();
            this.datetime_fechaven = new System.Windows.Forms.DateTimePicker();
            this.lbl_bsventa = new System.Windows.Forms.Label();
            this.lbl_bscompra = new System.Windows.Forms.Label();
            this.txt_pventa = new System.Windows.Forms.TextBox();
            this.txt_pcompra = new System.Windows.Forms.TextBox();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_pventa = new System.Windows.Forms.Label();
            this.lbl_pcompra = new System.Windows.Forms.Label();
            this.lbl_fvenc = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.domainUpDown_marca = new System.Windows.Forms.DomainUpDown();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pcompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_erase = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_producto)).BeginInit();
            this.groupBox_regproducto.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_producto
            // 
            this.dataGrid_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cod,
            this.col_nom,
            this.col_mar,
            this.col_cant,
            this.col_est,
            this.col_fven,
            this.col_pcompra,
            this.col_pventa,
            this.col_edit,
            this.col_erase});
            this.dataGrid_producto.Location = new System.Drawing.Point(323, 100);
            this.dataGrid_producto.Name = "dataGrid_producto";
            this.dataGrid_producto.RowHeadersWidth = 51;
            this.dataGrid_producto.RowTemplate.Height = 24;
            this.dataGrid_producto.Size = new System.Drawing.Size(821, 330);
            this.dataGrid_producto.TabIndex = 26;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(1014, 52);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(90, 27);
            this.btn_new.TabIndex = 25;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(901, 52);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(90, 27);
            this.btn_buscar.TabIndex = 24;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(325, 35);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(473, 21);
            this.lbl_buscar.TabIndex = 23;
            this.lbl_buscar.Text = "Buscar por: Codigo | Marca | Nombre | Disponibilidad";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(322, 66);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(553, 22);
            this.txt_busqueda.TabIndex = 22;
            // 
            // lbl_registrar
            // 
            this.lbl_registrar.AutoSize = true;
            this.lbl_registrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registrar.Location = new System.Drawing.Point(15, 26);
            this.lbl_registrar.Name = "lbl_registrar";
            this.lbl_registrar.Size = new System.Drawing.Size(196, 23);
            this.lbl_registrar.TabIndex = 21;
            this.lbl_registrar.Text = "Registrar Productos";
            // 
            // groupBox_regproducto
            // 
            this.groupBox_regproducto.Controls.Add(this.domainUpDown_marca);
            this.groupBox_regproducto.Controls.Add(this.comboBox1);
            this.groupBox_regproducto.Controls.Add(this.datetime_fechaven);
            this.groupBox_regproducto.Controls.Add(this.lbl_bsventa);
            this.groupBox_regproducto.Controls.Add(this.lbl_bscompra);
            this.groupBox_regproducto.Controls.Add(this.txt_pventa);
            this.groupBox_regproducto.Controls.Add(this.txt_pcompra);
            this.groupBox_regproducto.Controls.Add(this.txt_cant);
            this.groupBox_regproducto.Controls.Add(this.txt_nombre);
            this.groupBox_regproducto.Controls.Add(this.txt_codigo);
            this.groupBox_regproducto.Controls.Add(this.btn_cancel);
            this.groupBox_regproducto.Controls.Add(this.btn_guardar);
            this.groupBox_regproducto.Controls.Add(this.lbl_pventa);
            this.groupBox_regproducto.Controls.Add(this.lbl_pcompra);
            this.groupBox_regproducto.Controls.Add(this.lbl_fvenc);
            this.groupBox_regproducto.Controls.Add(this.lbl_estado);
            this.groupBox_regproducto.Controls.Add(this.lbl_cant);
            this.groupBox_regproducto.Controls.Add(this.lbl_marca);
            this.groupBox_regproducto.Controls.Add(this.lbl_nombre);
            this.groupBox_regproducto.Controls.Add(this.lbl_codigo);
            this.groupBox_regproducto.Location = new System.Drawing.Point(13, 52);
            this.groupBox_regproducto.Name = "groupBox_regproducto";
            this.groupBox_regproducto.Size = new System.Drawing.Size(304, 389);
            this.groupBox_regproducto.TabIndex = 20;
            this.groupBox_regproducto.TabStop = false;
            // 
            // datetime_fechaven
            // 
            this.datetime_fechaven.Location = new System.Drawing.Point(48, 220);
            this.datetime_fechaven.Name = "datetime_fechaven";
            this.datetime_fechaven.Size = new System.Drawing.Size(189, 22);
            this.datetime_fechaven.TabIndex = 19;
            // 
            // lbl_bsventa
            // 
            this.lbl_bsventa.AutoSize = true;
            this.lbl_bsventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bsventa.Location = new System.Drawing.Point(270, 297);
            this.lbl_bsventa.Name = "lbl_bsventa";
            this.lbl_bsventa.Size = new System.Drawing.Size(34, 20);
            this.lbl_bsventa.TabIndex = 17;
            this.lbl_bsventa.Text = "Bs.";
            // 
            // lbl_bscompra
            // 
            this.lbl_bscompra.AutoSize = true;
            this.lbl_bscompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bscompra.Location = new System.Drawing.Point(269, 263);
            this.lbl_bscompra.Name = "lbl_bscompra";
            this.lbl_bscompra.Size = new System.Drawing.Size(34, 20);
            this.lbl_bscompra.TabIndex = 16;
            this.lbl_bscompra.Text = "Bs.";
            // 
            // txt_pventa
            // 
            this.txt_pventa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pventa.Location = new System.Drawing.Point(180, 290);
            this.txt_pventa.Name = "txt_pventa";
            this.txt_pventa.Size = new System.Drawing.Size(87, 28);
            this.txt_pventa.TabIndex = 15;
            // 
            // txt_pcompra
            // 
            this.txt_pcompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pcompra.Location = new System.Drawing.Point(180, 255);
            this.txt_pcompra.Name = "txt_pcompra";
            this.txt_pcompra.Size = new System.Drawing.Size(87, 28);
            this.txt_pcompra.TabIndex = 14;
            // 
            // txt_cant
            // 
            this.txt_cant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant.Location = new System.Drawing.Point(106, 119);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(100, 28);
            this.txt_cant.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(106, 49);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 28);
            this.txt_nombre.TabIndex = 11;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(105, 15);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 28);
            this.txt_codigo.TabIndex = 10;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(157, 331);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 27);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(43, 331);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(90, 27);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_pventa
            // 
            this.lbl_pventa.AutoSize = true;
            this.lbl_pventa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pventa.Location = new System.Drawing.Point(19, 295);
            this.lbl_pventa.Name = "lbl_pventa";
            this.lbl_pventa.Size = new System.Drawing.Size(152, 21);
            this.lbl_pventa.TabIndex = 7;
            this.lbl_pventa.Text = "Precio de Venta:";
            // 
            // lbl_pcompra
            // 
            this.lbl_pcompra.AutoSize = true;
            this.lbl_pcompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcompra.Location = new System.Drawing.Point(6, 260);
            this.lbl_pcompra.Name = "lbl_pcompra";
            this.lbl_pcompra.Size = new System.Drawing.Size(168, 21);
            this.lbl_pcompra.TabIndex = 6;
            this.lbl_pcompra.Text = "Precio de Compra:";
            // 
            // lbl_fvenc
            // 
            this.lbl_fvenc.AutoSize = true;
            this.lbl_fvenc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fvenc.Location = new System.Drawing.Point(6, 189);
            this.lbl_fvenc.Name = "lbl_fvenc";
            this.lbl_fvenc.Size = new System.Drawing.Size(200, 21);
            this.lbl_fvenc.TabIndex = 5;
            this.lbl_fvenc.Text = "Fecha de Vencimiento";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(23, 154);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(73, 21);
            this.lbl_estado.TabIndex = 4;
            this.lbl_estado.Text = "Estado:";
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.Location = new System.Drawing.Point(-1, 124);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(97, 21);
            this.lbl_cant.TabIndex = 3;
            this.lbl_cant.Text = "Cantidad:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.Location = new System.Drawing.Point(27, 91);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(72, 21);
            this.lbl_marca.TabIndex = 2;
            this.lbl_marca.Text = "Marca:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(18, 47);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(82, 21);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(22, 18);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(77, 21);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1149, 26);
            this.statusStrip1.TabIndex = 27;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // domainUpDown_marca
            // 
            this.domainUpDown_marca.Location = new System.Drawing.Point(106, 89);
            this.domainUpDown_marca.Name = "domainUpDown_marca";
            this.domainUpDown_marca.Size = new System.Drawing.Size(99, 22);
            this.domainUpDown_marca.TabIndex = 21;
            this.domainUpDown_marca.Text = "ARCOR";
            // 
            // col_cod
            // 
            this.col_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_cod.HeaderText = "Codigo";
            this.col_cod.MinimumWidth = 6;
            this.col_cod.Name = "col_cod";
            this.col_cod.Width = 80;
            // 
            // col_nom
            // 
            this.col_nom.HeaderText = "Nombre";
            this.col_nom.MinimumWidth = 6;
            this.col_nom.Name = "col_nom";
            this.col_nom.Width = 80;
            // 
            // col_mar
            // 
            this.col_mar.HeaderText = "Marca";
            this.col_mar.MinimumWidth = 6;
            this.col_mar.Name = "col_mar";
            this.col_mar.Width = 80;
            // 
            // col_cant
            // 
            this.col_cant.HeaderText = "Cantidad";
            this.col_cant.MinimumWidth = 6;
            this.col_cant.Name = "col_cant";
            this.col_cant.Width = 80;
            // 
            // col_est
            // 
            this.col_est.HeaderText = "Estado";
            this.col_est.MinimumWidth = 6;
            this.col_est.Name = "col_est";
            this.col_est.Width = 80;
            // 
            // col_fven
            // 
            this.col_fven.HeaderText = "FechaVenc";
            this.col_fven.MinimumWidth = 6;
            this.col_fven.Name = "col_fven";
            this.col_fven.Width = 90;
            // 
            // col_pcompra
            // 
            this.col_pcompra.HeaderText = "Precio Compra";
            this.col_pcompra.MinimumWidth = 6;
            this.col_pcompra.Name = "col_pcompra";
            this.col_pcompra.Width = 95;
            // 
            // col_pventa
            // 
            this.col_pventa.HeaderText = "Precio Venta";
            this.col_pventa.MinimumWidth = 6;
            this.col_pventa.Name = "col_pventa";
            this.col_pventa.Width = 80;
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
            // FrmCrudProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 470);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGrid_producto);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.lbl_registrar);
            this.Controls.Add(this.groupBox_regproducto);
            this.Name = "FrmCrudProducto";
            this.Text = "FrmCrudProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_producto)).EndInit();
            this.groupBox_regproducto.ResumeLayout(false);
            this.groupBox_regproducto.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_producto;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_registrar;
        private System.Windows.Forms.GroupBox groupBox_regproducto;
        private System.Windows.Forms.DateTimePicker datetime_fechaven;
        private System.Windows.Forms.Label lbl_bsventa;
        private System.Windows.Forms.Label lbl_bscompra;
        private System.Windows.Forms.TextBox txt_pventa;
        private System.Windows.Forms.TextBox txt_pcompra;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_pventa;
        private System.Windows.Forms.Label lbl_pcompra;
        private System.Windows.Forms.Label lbl_fvenc;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.DomainUpDown domainUpDown_marca;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_est;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fven;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pventa;
        private System.Windows.Forms.DataGridViewImageColumn col_edit;
        private System.Windows.Forms.DataGridViewImageColumn col_erase;
    }
}