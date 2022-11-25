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
    public partial class FrmClienteBuscar : Form
    {

        Cliente MiCliente;
       
        public FrmClienteBuscar()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count > 0)
            {
                DataGridViewRow Fila = DgvLista.SelectedRows[0];
                int idCliente = (int)Fila.Cells["CIDCliente"].Value;
                Globales.MiFormFacturacion.TxtClienteId.Text = Convert.ToString(idCliente);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FrmClienteBuscar_Load(object sender, EventArgs e)
        {
            MiCliente = new Cliente();
            DgvLista.DataSource =  MiCliente.Listar();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DgvLista.DataSource = MiCliente.Listar(true,TxtBuscar.Text.Trim());
        }
    }
}
