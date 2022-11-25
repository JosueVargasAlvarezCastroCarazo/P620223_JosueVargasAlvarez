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
    public partial class FrmPrincipalMDI : Form
    {
        public FrmPrincipalMDI()
        {
            InitializeComponent();
        }

        private void FrmPrincipalMDI_Load(object sender, EventArgs e)
        {
            StatusLabel.Text = "Nombre Usuario: " + Globales.MiUsuario.Nombre;

            //bodeguero
            if (Globales.MiUsuario.MiUsuarioRol.IDUsuarioRol == 3)
            {
                procesosToolStripMenuItem.Visible = false;
                galeriaDeReportesToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = false;
                impuestosToolStripMenuItem.Visible = false;
                categoriasToolStripMenuItem.Visible = false;

            }

            //facturador
            if (Globales.MiUsuario.MiUsuarioRol.IDUsuarioRol == 2)
            {
                galeriaDeReportesToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = false;
            }
        
        
        }

        private void FrmPrincipalMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormMantenimientoUsuarios.Visible)
            {
                Globales.MiFormMantenimientoUsuarios = new Formularios.FrmUsuariosGestion();
                Globales.MiFormMantenimientoUsuarios.Show();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StatusLabel.Text = "Nombre Usuario: " + Globales.MiUsuario.Nombre+" Timepo: "+ DateTime.Now;
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormFacturacion.Visible)
            {
                Globales.MiFormFacturacion = new Formularios.FrmFacturacion();
                Globales.MiFormFacturacion.Show();
            }
            
        }
    }
}
