namespace P620223_JosueVargasAlvarez.Formularios
{
    partial class FrmInventarioBuscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CIDInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadEnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar producto";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(589, 376);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Location = new System.Drawing.Point(670, 376);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(114, 23);
            this.BtnSeleccionar.TabIndex = 7;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDInventario,
            this.CNombreItem,
            this.CCodigoBarras,
            this.CCosto,
            this.CPrecioVenta,
            this.CCantidadEnStock,
            this.CTasaImpuesto,
            this.CNombreCategoria});
            this.DgvLista.Location = new System.Drawing.Point(12, 99);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(776, 166);
            this.DgvLista.TabIndex = 6;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
            // 
            // CIDInventario
            // 
            this.CIDInventario.DataPropertyName = "IDInventario";
            this.CIDInventario.HeaderText = "ID";
            this.CIDInventario.Name = "CIDInventario";
            this.CIDInventario.ReadOnly = true;
            this.CIDInventario.Width = 45;
            // 
            // CNombreItem
            // 
            this.CNombreItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombreItem.DataPropertyName = "NombreItem";
            this.CNombreItem.HeaderText = "Nombre";
            this.CNombreItem.Name = "CNombreItem";
            this.CNombreItem.ReadOnly = true;
            // 
            // CCodigoBarras
            // 
            this.CCodigoBarras.DataPropertyName = "CodigoBarras";
            this.CCodigoBarras.HeaderText = "Codigo";
            this.CCodigoBarras.Name = "CCodigoBarras";
            this.CCodigoBarras.ReadOnly = true;
            this.CCodigoBarras.Width = 76;
            // 
            // CCosto
            // 
            this.CCosto.DataPropertyName = "Costo";
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            this.CCosto.Width = 67;
            // 
            // CPrecioVenta
            // 
            this.CPrecioVenta.DataPropertyName = "PrecioVenta";
            this.CPrecioVenta.HeaderText = "Precio";
            this.CPrecioVenta.Name = "CPrecioVenta";
            this.CPrecioVenta.ReadOnly = true;
            this.CPrecioVenta.Width = 71;
            // 
            // CCantidadEnStock
            // 
            this.CCantidadEnStock.DataPropertyName = "CantidadEnStock";
            this.CCantidadEnStock.HeaderText = "Cantidad";
            this.CCantidadEnStock.Name = "CCantidadEnStock";
            this.CCantidadEnStock.ReadOnly = true;
            this.CCantidadEnStock.Width = 86;
            // 
            // CTasaImpuesto
            // 
            this.CTasaImpuesto.DataPropertyName = "TasaImpuesto";
            this.CTasaImpuesto.HeaderText = "Impuesto";
            this.CTasaImpuesto.Name = "CTasaImpuesto";
            this.CTasaImpuesto.ReadOnly = true;
            this.CTasaImpuesto.Width = 87;
            // 
            // CNombreCategoria
            // 
            this.CNombreCategoria.DataPropertyName = "NombreCategoria";
            this.CNombreCategoria.HeaderText = "Categoria";
            this.CNombreCategoria.Name = "CNombreCategoria";
            this.CNombreCategoria.ReadOnly = true;
            this.CNombreCategoria.Width = 91;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(228, 59);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(325, 22);
            this.TxtBuscar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descuento";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(15, 304);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(103, 22);
            this.TxtDescuento.TabIndex = 11;
            this.TxtDescuento.Text = "0";
            this.TxtDescuento.TextChanged += new System.EventHandler(this.TxtDescuento_TextChanged);
            this.TxtDescuento.Leave += new System.EventHandler(this.TxtDescuento_Leave);
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Location = new System.Drawing.Point(140, 305);
            this.NUDCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(120, 22);
            this.NUDCantidad.TabIndex = 12;
            this.NUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCantidad.ValueChanged += new System.EventHandler(this.NUDCantidad_ValueChanged);
            this.NUDCantidad.Leave += new System.EventHandler(this.NUDCantidad_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad";
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(278, 305);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.ReadOnly = true;
            this.TxtIva.Size = new System.Drawing.Size(103, 22);
            this.TxtIva.TabIndex = 15;
            this.TxtIva.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "% IVA";
            // 
            // TxtPrecioUnidad
            // 
            this.TxtPrecioUnidad.Location = new System.Drawing.Point(397, 305);
            this.TxtPrecioUnidad.Name = "TxtPrecioUnidad";
            this.TxtPrecioUnidad.ReadOnly = true;
            this.TxtPrecioUnidad.Size = new System.Drawing.Size(103, 22);
            this.TxtPrecioUnidad.TabIndex = 17;
            this.TxtPrecioUnidad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio unidad";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(515, 303);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(103, 22);
            this.TxtTotal.TabIndex = 19;
            this.TxtTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total";
            // 
            // FrmInventarioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPrecioUnidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUDCantidad);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.TxtBuscar);
            this.Name = "FrmInventarioBuscar";
            this.Text = "Buscar producto";
            this.Load += new System.EventHandler(this.FrmInventarioBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadEnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrecioUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label6;
    }
}