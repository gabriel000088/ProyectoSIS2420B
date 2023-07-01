namespace Productos
{
    partial class Frm_gstproducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_regproducto = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datetime_fechaven = new System.Windows.Forms.DateTimePicker();
            this.lbl_bsventa = new System.Windows.Forms.Label();
            this.lbl_bscompra = new System.Windows.Forms.Label();
            this.txt_pventa = new System.Windows.Forms.TextBox();
            this.txt_pcompra = new System.Windows.Forms.TextBox();
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
            this.lbl_registrar = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.dataGrid_producto = new System.Windows.Forms.DataGridView();
            this.col_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pcompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_option = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ToolStripContainer = new System.Windows.Forms.StatusStrip();
            this.lbl_Rol = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_RolUs = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_regproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_producto)).BeginInit();
            this.ToolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_regproducto
            // 
            this.groupBox_regproducto.Controls.Add(this.comboBox1);
            this.groupBox_regproducto.Controls.Add(this.textBox2);
            this.groupBox_regproducto.Controls.Add(this.textBox1);
            this.groupBox_regproducto.Controls.Add(this.datetime_fechaven);
            this.groupBox_regproducto.Controls.Add(this.lbl_bsventa);
            this.groupBox_regproducto.Controls.Add(this.lbl_bscompra);
            this.groupBox_regproducto.Controls.Add(this.txt_pventa);
            this.groupBox_regproducto.Controls.Add(this.txt_pcompra);
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
            this.groupBox_regproducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_regproducto.Location = new System.Drawing.Point(11, 94);
            this.groupBox_regproducto.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_regproducto.Name = "groupBox_regproducto";
            this.groupBox_regproducto.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_regproducto.Size = new System.Drawing.Size(263, 374);
            this.groupBox_regproducto.TabIndex = 0;
            this.groupBox_regproducto.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.comboBox1.Location = new System.Drawing.Point(85, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Seleccione";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 85);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 25);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 25);
            this.textBox1.TabIndex = 20;
            // 
            // datetime_fechaven
            // 
            this.datetime_fechaven.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_fechaven.Location = new System.Drawing.Point(136, 195);
            this.datetime_fechaven.Margin = new System.Windows.Forms.Padding(2);
            this.datetime_fechaven.Name = "datetime_fechaven";
            this.datetime_fechaven.Size = new System.Drawing.Size(88, 25);
            this.datetime_fechaven.TabIndex = 19;
            // 
            // lbl_bsventa
            // 
            this.lbl_bsventa.AutoSize = true;
            this.lbl_bsventa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bsventa.Location = new System.Drawing.Point(217, 269);
            this.lbl_bsventa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bsventa.Name = "lbl_bsventa";
            this.lbl_bsventa.Size = new System.Drawing.Size(31, 19);
            this.lbl_bsventa.TabIndex = 17;
            this.lbl_bsventa.Text = "Bs.";
            // 
            // lbl_bscompra
            // 
            this.lbl_bscompra.AutoSize = true;
            this.lbl_bscompra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bscompra.Location = new System.Drawing.Point(217, 228);
            this.lbl_bscompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bscompra.Name = "lbl_bscompra";
            this.lbl_bscompra.Size = new System.Drawing.Size(31, 19);
            this.lbl_bscompra.TabIndex = 16;
            this.lbl_bscompra.Text = "Bs.";
            // 
            // txt_pventa
            // 
            this.txt_pventa.Location = new System.Drawing.Point(137, 263);
            this.txt_pventa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pventa.Name = "txt_pventa";
            this.txt_pventa.Size = new System.Drawing.Size(76, 25);
            this.txt_pventa.TabIndex = 15;
            // 
            // txt_pcompra
            // 
            this.txt_pcompra.Location = new System.Drawing.Point(136, 227);
            this.txt_pcompra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pcompra.Name = "txt_pcompra";
            this.txt_pcompra.Size = new System.Drawing.Size(76, 25);
            this.txt_pcompra.TabIndex = 14;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(85, 119);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 25);
            this.txt_nombre.TabIndex = 11;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(85, 20);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(76, 25);
            this.txt_codigo.TabIndex = 10;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(112, 317);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 43);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(27, 317);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(80, 43);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_pventa
            // 
            this.lbl_pventa.AutoSize = true;
            this.lbl_pventa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pventa.Location = new System.Drawing.Point(10, 264);
            this.lbl_pventa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pventa.Name = "lbl_pventa";
            this.lbl_pventa.Size = new System.Drawing.Size(119, 19);
            this.lbl_pventa.TabIndex = 7;
            this.lbl_pventa.Text = "Precio de Venta:";
            // 
            // lbl_pcompra
            // 
            this.lbl_pcompra.AutoSize = true;
            this.lbl_pcompra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcompra.Location = new System.Drawing.Point(-4, 228);
            this.lbl_pcompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pcompra.Name = "lbl_pcompra";
            this.lbl_pcompra.Size = new System.Drawing.Size(133, 19);
            this.lbl_pcompra.TabIndex = 6;
            this.lbl_pcompra.Text = "Precio de Compra:";
            // 
            // lbl_fvenc
            // 
            this.lbl_fvenc.AutoSize = true;
            this.lbl_fvenc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fvenc.Location = new System.Drawing.Point(0, 195);
            this.lbl_fvenc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fvenc.Name = "lbl_fvenc";
            this.lbl_fvenc.Size = new System.Drawing.Size(111, 19);
            this.lbl_fvenc.TabIndex = 5;
            this.lbl_fvenc.Text = "Fecha de Venc:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(19, 162);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(60, 19);
            this.lbl_estado.TabIndex = 4;
            this.lbl_estado.Text = "Estado:";
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.Location = new System.Drawing.Point(7, 125);
            this.lbl_cant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(74, 19);
            this.lbl_cant.TabIndex = 3;
            this.lbl_cant.Text = "Cantidad:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.Location = new System.Drawing.Point(13, 85);
            this.lbl_marca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(59, 19);
            this.lbl_marca.TabIndex = 2;
            this.lbl_marca.Text = "Marca:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(4, 55);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 19);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(13, 20);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(61, 19);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo:";
            // 
            // lbl_registrar
            // 
            this.lbl_registrar.AutoSize = true;
            this.lbl_registrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registrar.Location = new System.Drawing.Point(11, 24);
            this.lbl_registrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_registrar.Name = "lbl_registrar";
            this.lbl_registrar.Size = new System.Drawing.Size(143, 19);
            this.lbl_registrar.TabIndex = 1;
            this.lbl_registrar.Text = "Registrar Productos";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(322, 50);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(461, 26);
            this.txt_busqueda.TabIndex = 15;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(318, 25);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(365, 19);
            this.lbl_buscar.TabIndex = 16;
            this.lbl_buscar.Text = "Buscar por: Codigo | Marca | Nombre | Disponibilidad";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(830, 49);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(86, 27);
            this.btn_buscar.TabIndex = 17;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(920, 49);
            this.btn_new.Margin = new System.Windows.Forms.Padding(2);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(86, 27);
            this.btn_new.TabIndex = 18;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
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
            this.col_option});
            this.dataGrid_producto.Location = new System.Drawing.Point(280, 94);
            this.dataGrid_producto.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid_producto.Name = "dataGrid_producto";
            this.dataGrid_producto.RowHeadersWidth = 51;
            this.dataGrid_producto.RowTemplate.Height = 24;
            this.dataGrid_producto.Size = new System.Drawing.Size(909, 418);
            this.dataGrid_producto.TabIndex = 19;
            this.dataGrid_producto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_producto_CellContentClick);
            // 
            // col_cod
            // 
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
            this.col_fven.Width = 125;
            // 
            // col_pcompra
            // 
            this.col_pcompra.HeaderText = "Precio Compra";
            this.col_pcompra.MinimumWidth = 6;
            this.col_pcompra.Name = "col_pcompra";
            this.col_pcompra.Width = 125;
            // 
            // col_pventa
            // 
            this.col_pventa.HeaderText = "Precio Venta";
            this.col_pventa.MinimumWidth = 6;
            this.col_pventa.Name = "col_pventa";
            this.col_pventa.Width = 125;
            // 
            // col_option
            // 
            this.col_option.HeaderText = "Opciones";
            this.col_option.MinimumWidth = 6;
            this.col_option.Name = "col_option";
            this.col_option.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_option.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_option.Text = "";
            this.col_option.Width = 80;
            // 
            // ToolStripContainer
            // 
            this.ToolStripContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Rol,
            this.lbl_RolUs});
            this.ToolStripContainer.Location = new System.Drawing.Point(0, 514);
            this.ToolStripContainer.Name = "ToolStripContainer";
            this.ToolStripContainer.Size = new System.Drawing.Size(1200, 22);
            this.ToolStripContainer.TabIndex = 20;
            this.ToolStripContainer.Text = "statusStrip1";
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
            // Frm_gstproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 536);
            this.Controls.Add(this.ToolStripContainer);
            this.Controls.Add(this.dataGrid_producto);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.lbl_registrar);
            this.Controls.Add(this.groupBox_regproducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_gstproducto";
            this.Text = "Gestionar Producto";
            this.groupBox_regproducto.ResumeLayout(false);
            this.groupBox_regproducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_producto)).EndInit();
            this.ToolStripContainer.ResumeLayout(false);
            this.ToolStripContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_regproducto;
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
        private System.Windows.Forms.Label lbl_registrar;
        private System.Windows.Forms.Label lbl_bsventa;
        private System.Windows.Forms.Label lbl_bscompra;
        private System.Windows.Forms.TextBox txt_pventa;
        private System.Windows.Forms.TextBox txt_pcompra;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DateTimePicker datetime_fechaven;
        private System.Windows.Forms.DataGridView dataGrid_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_est;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fven;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pventa;
        private System.Windows.Forms.DataGridViewButtonColumn col_option;
        private System.Windows.Forms.StatusStrip ToolStripContainer;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Rol;
        private System.Windows.Forms.ToolStripStatusLabel lbl_RolUs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

