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

            }
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtDescuento.Text))
            {
                TxtDescuento.Text = "0";
            }
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

    }
}
