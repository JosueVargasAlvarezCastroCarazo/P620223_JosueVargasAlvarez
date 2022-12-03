namespace P620223_JosueVargasAlvarez.Formularios
{
    partial class FrmFacturacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.LblClienteNombre = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboFacturaTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClienteId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CIDInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescuentoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImpuestosTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripFacturacion = new System.Windows.Forms.MenuStrip();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCrearFactura = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtImpuestos = new System.Windows.Forms.TextBox();
            this.TxtDescuentos = new System.Windows.Forms.TextBox();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.menuStripFacturacion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscarCliente);
            this.groupBox1.Controls.Add(this.LblClienteNombre);
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboFacturaTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtClienteId);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(720, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Location = new System.Drawing.Point(276, 63);
            this.BtnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(100, 28);
            this.BtnBuscarCliente.TabIndex = 7;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // LblClienteNombre
            // 
            this.LblClienteNombre.AutoSize = true;
            this.LblClienteNombre.Location = new System.Drawing.Point(40, 98);
            this.LblClienteNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClienteNombre.Name = "LblClienteNombre";
            this.LblClienteNombre.Size = new System.Drawing.Size(103, 16);
            this.LblClienteNombre.TabIndex = 6;
            this.LblClienteNombre.Text = "Nombre Cliente:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(40, 158);
            this.TxtNotas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotas.Size = new System.Drawing.Size(631, 102);
            this.TxtNotas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notas";
            // 
            // CboFacturaTipo
            // 
            this.CboFacturaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFacturaTipo.FormattingEnabled = true;
            this.CboFacturaTipo.Location = new System.Drawing.Point(405, 65);
            this.CboFacturaTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CboFacturaTipo.Name = "CboFacturaTipo";
            this.CboFacturaTipo.Size = new System.Drawing.Size(265, 24);
            this.CboFacturaTipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // TxtClienteId
            // 
            this.TxtClienteId.Location = new System.Drawing.Point(40, 65);
            this.TxtClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtClienteId.Name = "TxtClienteId";
            this.TxtClienteId.Size = new System.Drawing.Size(227, 22);
            this.TxtClienteId.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvLista);
            this.groupBox2.Controls.Add(this.menuStripFacturacion);
            this.groupBox2.Location = new System.Drawing.Point(16, 314);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(720, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDInventario,
            this.CNombreItem,
            this.CPrecioVenta,
            this.CCantidad,
            this.CTasaImpuesto,
            this.CPorcentajeDescuento,
            this.CSubTotal,
            this.CDescuentoTotal,
            this.CSubTotal2,
            this.CImpuestosTotal,
            this.CTotalLinea});
            this.DgvLista.Location = new System.Drawing.Point(4, 53);
            this.DgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(712, 185);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            // 
            // CIDInventario
            // 
            this.CIDInventario.DataPropertyName = "IDInventario";
            this.CIDInventario.HeaderText = "Cod";
            this.CIDInventario.Name = "CIDInventario";
            this.CIDInventario.ReadOnly = true;
            // 
            // CNombreItem
            // 
            this.CNombreItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombreItem.DataPropertyName = "NombreItem";
            this.CNombreItem.HeaderText = "Item";
            this.CNombreItem.Name = "CNombreItem";
            this.CNombreItem.ReadOnly = true;
            // 
            // CPrecioVenta
            // 
            this.CPrecioVenta.DataPropertyName = "PrecioVenta";
            this.CPrecioVenta.HeaderText = "Precio";
            this.CPrecioVenta.Name = "CPrecioVenta";
            this.CPrecioVenta.ReadOnly = true;
            // 
            // CCantidad
            // 
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            // 
            // CTasaImpuesto
            // 
            this.CTasaImpuesto.DataPropertyName = "TasaImpuesto";
            this.CTasaImpuesto.HeaderText = "Impuesto";
            this.CTasaImpuesto.Name = "CTasaImpuesto";
            this.CTasaImpuesto.ReadOnly = true;
            // 
            // CPorcentajeDescuento
            // 
            this.CPorcentajeDescuento.DataPropertyName = "PorcentajeDescuento";
            this.CPorcentajeDescuento.HeaderText = "Descuento";
            this.CPorcentajeDescuento.Name = "CPorcentajeDescuento";
            this.CPorcentajeDescuento.ReadOnly = true;
            // 
            // CSubTotal
            // 
            this.CSubTotal.DataPropertyName = "SubTotal";
            this.CSubTotal.HeaderText = "SubTotal";
            this.CSubTotal.Name = "CSubTotal";
            this.CSubTotal.ReadOnly = true;
            this.CSubTotal.Visible = false;
            // 
            // CDescuentoTotal
            // 
            this.CDescuentoTotal.DataPropertyName = "DescuentoTotal";
            this.CDescuentoTotal.HeaderText = "DesTotal";
            this.CDescuentoTotal.Name = "CDescuentoTotal";
            this.CDescuentoTotal.ReadOnly = true;
            this.CDescuentoTotal.Visible = false;
            // 
            // CSubTotal2
            // 
            this.CSubTotal2.DataPropertyName = "SubTotal2";
            this.CSubTotal2.HeaderText = "sub2";
            this.CSubTotal2.Name = "CSubTotal2";
            this.CSubTotal2.ReadOnly = true;
            this.CSubTotal2.Visible = false;
            // 
            // CImpuestosTotal
            // 
            this.CImpuestosTotal.DataPropertyName = "ImpuestosTotal";
            this.CImpuestosTotal.HeaderText = "Impuesto Total";
            this.CImpuestosTotal.Name = "CImpuestosTotal";
            this.CImpuestosTotal.ReadOnly = true;
            this.CImpuestosTotal.Visible = false;
            // 
            // CTotalLinea
            // 
            this.CTotalLinea.DataPropertyName = "TotalLinea";
            this.CTotalLinea.HeaderText = "TotalLinea";
            this.CTotalLinea.Name = "CTotalLinea";
            this.CTotalLinea.ReadOnly = true;
            this.CTotalLinea.Visible = false;
            // 
            // menuStripFacturacion
            // 
            this.menuStripFacturacion.AllowMerge = false;
            this.menuStripFacturacion.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripFacturacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.quitarProductoToolStripMenuItem});
            this.menuStripFacturacion.Location = new System.Drawing.Point(4, 22);
            this.menuStripFacturacion.Name = "menuStripFacturacion";
            this.menuStripFacturacion.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripFacturacion.Size = new System.Drawing.Size(349, 24);
            this.menuStripFacturacion.TabIndex = 0;
            this.menuStripFacturacion.Text = "menuStrip1";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            // 
            // quitarProductoToolStripMenuItem
            // 
            this.quitarProductoToolStripMenuItem.Name = "quitarProductoToolStripMenuItem";
            this.quitarProductoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.quitarProductoToolStripMenuItem.Text = "Quitar Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCrearFactura);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtTotal);
            this.groupBox3.Controls.Add(this.TxtImpuestos);
            this.groupBox3.Controls.Add(this.TxtDescuentos);
            this.groupBox3.Controls.Add(this.TxtSubTotal);
            this.groupBox3.Location = new System.Drawing.Point(17, 571);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(719, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // BtnCrearFactura
            // 
            this.BtnCrearFactura.Location = new System.Drawing.Point(559, 90);
            this.BtnCrearFactura.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCrearFactura.Name = "BtnCrearFactura";
            this.BtnCrearFactura.Size = new System.Drawing.Size(152, 28);
            this.BtnCrearFactura.TabIndex = 8;
            this.BtnCrearFactura.Text = "Crear Factura";
            this.BtnCrearFactura.UseVisualStyleBackColor = true;
            this.BtnCrearFactura.Click += new System.EventHandler(this.BtnCrearFactura_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Impuestos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descuentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "SubTotal";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(559, 58);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(151, 22);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.Text = "0";
            // 
            // TxtImpuestos
            // 
            this.TxtImpuestos.Location = new System.Drawing.Point(377, 58);
            this.TxtImpuestos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtImpuestos.Name = "TxtImpuestos";
            this.TxtImpuestos.Size = new System.Drawing.Size(172, 22);
            this.TxtImpuestos.TabIndex = 2;
            this.TxtImpuestos.Text = "0";
            // 
            // TxtDescuentos
            // 
            this.TxtDescuentos.Location = new System.Drawing.Point(192, 58);
            this.TxtDescuentos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescuentos.Name = "TxtDescuentos";
            this.TxtDescuentos.Size = new System.Drawing.Size(176, 22);
            this.TxtDescuentos.TabIndex = 1;
            this.TxtDescuentos.Text = "0";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(15, 58);
            this.TxtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(152, 22);
            this.TxtSubTotal.TabIndex = 0;
            this.TxtSubTotal.Text = "0";
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 716);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStripFacturacion;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.menuStripFacturacion.ResumeLayout(false);
            this.menuStripFacturacion.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Label LblClienteNombre;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboFacturaTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStripFacturacion;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarProductoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCrearFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtImpuestos;
        private System.Windows.Forms.TextBox TxtDescuentos;
        private System.Windows.Forms.TextBox TxtSubTotal;
        public System.Windows.Forms.TextBox TxtClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescuentoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImpuestosTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLinea;
    }
}