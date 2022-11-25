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
    }
}
