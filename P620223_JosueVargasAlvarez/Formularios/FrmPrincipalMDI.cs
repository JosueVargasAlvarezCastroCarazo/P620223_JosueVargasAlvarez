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
    }
}
