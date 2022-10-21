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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void TxtVerContra_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtVerContra_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContra.UseSystemPasswordChar = false;
        }

        private void TxtVerContra_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContra.UseSystemPasswordChar = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globales.MiFromPrincipal.Show();
        }
    }
}
