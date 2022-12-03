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
    public partial class FrmFacturacion : Form
    {


        Factura MiFactura { get; set; }
        
        public DataTable DtListaitems { get; set; }

        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFromPrincipal;
            MiFactura = new Factura();
            DtListaitems = new DataTable();
            LlenarComboTiposFactura();
            Limpiar();
        }

        private void LlenarComboTiposFactura()
        {
            DataTable dt = new DataTable();

            dt = MiFactura.MiFacturaTipo.Listar();


            if (dt != null && dt.Rows.Count > 0)
            {
                CboFacturaTipo.ValueMember = "ID";
                CboFacturaTipo.DisplayMember = "D";
                CboFacturaTipo.DataSource = dt;
                CboFacturaTipo.SelectedIndex = -1;
            }

        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form FormBusqueda = new FrmClienteBuscar();

            DialogResult Resp = FormBusqueda.ShowDialog();

            if (Resp == DialogResult.OK)
            {
                int IdCliente = Int32.Parse(TxtClienteId.Text.Trim());
                MiFactura.MiCliente.IDCliente = IdCliente;
                MiFactura.MiCliente = MiFactura.MiCliente.ConsultarPorID();
                LblClienteNombre.Text = MiFactura.MiCliente.Nombre;
            }

        }

        private void Limpiar()
        {

            MiFactura = new Factura();

            TxtClienteId.Clear();
            LblClienteNombre.Text = "Cliente:";
            TxtNotas.Clear();
            CboFacturaTipo.SelectedIndex = -1;

            TxtSubTotal.Text = "0";
            TxtTotal.Text = "0";
            TxtDescuentos.Text = "0";
            TxtImpuestos.Text = "0";

            DtListaitems = MiFactura.CargarSchemaListaDetalle();
            DgvLista.DataSource = DtListaitems;
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormBusqueda = new FrmInventarioBuscar();

            DialogResult Resp = FormBusqueda.ShowDialog();

            if (Resp == DialogResult.OK)
            {
                DgvLista.DataSource = DtListaitems;
                TotalizarLista();
            }
        }

        private void TotalizarLista()
        {
            decimal Descuentos = 0;
            decimal Impuestos = 0;
            decimal SubTotal = 0;
            decimal Total = 0;


            if (DtListaitems.Rows.Count > 0)
            {

                foreach (DataRow item in DtListaitems.Rows)
                {

                    Descuentos += Convert.ToDecimal(item["DescuentoTotal"]);
                    Impuestos += Convert.ToDecimal(item["ImpuestosTotal"]);
                    SubTotal += Convert.ToDecimal(item["SubTotal"]);
                    Total += Convert.ToDecimal(item["TotalLinea"]);
                }

                TxtDescuentos.Text = Descuentos.ToString();
                TxtImpuestos.Text = Impuestos.ToString();
                TxtSubTotal.Text = SubTotal.ToString();
                TxtTotal.Text = Total.ToString();

            }

        }

        private void BtnCrearFactura_Click(object sender, EventArgs e)
        {

            if (ValidarFactura())
            {
                MiFactura.MiFacturaTipo.IDFacturaTipo = Convert.ToInt32(CboFacturaTipo.SelectedValue);
                MiFactura.MiCliente.IDCliente = Convert.ToInt32(TxtClienteId.Text.Trim());
                MiFactura.MiUsuario.IDUsuario = Globales.MiUsuario.IDUsuario;
                MiFactura.Notas = TxtNotas.Text.Trim();

                CargarDetalleFactura();

                if (MiFactura.Agregar() > 0 )
                {
                    MessageBox.Show("Factura agregada");
                    Limpiar();
                }

            }

        }


        private void CargarDetalleFactura()
        {
            if (DtListaitems.Rows.Count > 0)
            {

                foreach (DataRow NuevaFila in DtListaitems.Rows)
                {

                    FacturaInventario Detalle = new FacturaInventario();

                    Detalle.MiInventario.IDInventario = Convert.ToInt32(NuevaFila["IDInventario"]);
                    Detalle.Costo = 0;
                    Detalle.PrecioVenta = Convert.ToDecimal(NuevaFila["PrecioVenta"]);
                    Detalle.Cantidad = Convert.ToInt32(NuevaFila["Cantidad"]);
                    Detalle.PorcentajeImpuesto = Convert.ToDecimal(NuevaFila["TasaImpuesto"]);
                    Detalle.PorcentajeDescuento = Convert.ToDecimal(NuevaFila["PorcentajeDescuento"]);
                    Detalle.SubTotal = Convert.ToDecimal(NuevaFila["SubTotal"]);
                    Detalle.DescuentoTotal = Convert.ToDecimal(NuevaFila["DescuentoTotal"]);
                    Detalle.SubTotal2 = Convert.ToDecimal(NuevaFila["SubTotal2"]);
                    Detalle.ImpuestosTotal = Convert.ToDecimal(NuevaFila["ImpuestosTotal"]);
                    Detalle.TotalLinea = Convert.ToDecimal(NuevaFila["TotalLinea"]);

                    MiFactura.Detalle.Add(Detalle);

                }

            }
        }



        private bool ValidarFactura()
        {
            if (!string.IsNullOrEmpty(LblClienteNombre.Text.Trim()) && CboFacturaTipo.SelectedIndex > -1 && DtListaitems.Rows.Count > 0)
            {
                return true;
            }
            //todo validar casos contrarios

            return false;
        }
    }
}
