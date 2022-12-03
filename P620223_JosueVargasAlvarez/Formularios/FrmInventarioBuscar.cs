using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_JosueVargasAlvarez.Formularios
{
    public partial class FrmInventarioBuscar : Form
    {

        Inventario MiInventario;

        public decimal SubTotal1 { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal TotalImpuesto { get; set; }
        public decimal Total { get; set; }

        public decimal Precio { get; set; }
        public decimal Iva { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Descuento { get; set; }

        public FrmInventarioBuscar()
        {
            InitializeComponent();
        }

        private void FrmInventarioBuscar_Load(object sender, EventArgs e)
        {
            MiInventario = new Inventario();
            DgvLista.DataSource = MiInventario.Listar(true);
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count > 0)
            {
                decimal Precio = Convert.ToDecimal(DgvLista.SelectedRows[0].Cells["CPrecioVenta"].Value);
                decimal Iva = Convert.ToDecimal(DgvLista.SelectedRows[0].Cells["CTasaImpuesto"].Value);


                TxtIva.Text = Iva.ToString();
                TxtPrecioUnidad.Text = Precio.ToString();
                NUDCantidad.Value = 1;
                TxtDescuento.Text = "0";

                calcular();

            }
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtDescuento.Text))
            {
                TxtDescuento.Text = "0";
            }
            calcular();
        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            calcular();
        }

        private void NUDCantidad_Leave(object sender, EventArgs e)
        {
            calcular();
        }


        private void calcular()
        {
            if (ValidarDescuento())
            {

                Precio = Convert.ToDecimal(TxtPrecioUnidad.Text.Trim());
                Iva = Convert.ToDecimal(TxtIva.Text.Trim());
                Cantidad = Convert.ToDecimal(NUDCantidad.Value);
                Descuento = Convert.ToDecimal(TxtDescuento.Text.Trim());

                SubTotal1 = Cantidad * Precio;

                if (Descuento > 0)
                {
                    TotalDescuento = (SubTotal1 * Descuento) / 100;
                }
                else
                {
                    TotalDescuento = 0;
                }

                SubTotal2 = SubTotal1 - TotalDescuento;

                if (Iva > 0)
                {
                    TotalImpuesto = (SubTotal2 * Iva) / 100;
                }
                else
                {
                    TotalImpuesto = 0;
                }

                Total = SubTotal2 + TotalImpuesto;

                TxtTotal.Text = String.Format("{0:C2}",Total);

            }
        }

        private bool ValidarDescuento()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtDescuento.Text.Trim()) && Convert.ToDecimal(TxtDescuento.Text.Trim()) <= 100)
            {
                R = true;
            }

            return R;
        }

        private void NUDCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtTotal.Text))
            {
                int IdItem = Convert.ToInt32(DgvLista.SelectedRows[0].Cells["CIDInventario"].Value);
                String Nombre = Convert.ToString(DgvLista.SelectedRows[0].Cells["CNombreItem"].Value);

                DataRow NuevaFila = Globales.MiFormFacturacion.DtListaitems.NewRow();

                NuevaFila["IDInventario"] = IdItem;
                NuevaFila["NombreItem"] = Nombre;
                NuevaFila["PrecioVenta"] = Precio;
                NuevaFila["Cantidad"] = Cantidad;
                NuevaFila["TasaImpuesto"] = Iva;
                NuevaFila["PorcentajeDescuento"] = Descuento;
                NuevaFila["SubTotal"] = SubTotal1;
                NuevaFila["DescuentoTotal"] = TotalDescuento;
                NuevaFila["SubTotal2"] = SubTotal2;
                NuevaFila["ImpuestosTotal"] = TotalImpuesto;
                NuevaFila["TotalLinea"] = Total;

                Globales.MiFormFacturacion.DtListaitems.Rows.Add(NuevaFila);

                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
