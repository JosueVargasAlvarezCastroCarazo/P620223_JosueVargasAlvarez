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
            Usuario MiUsuario = new Usuario();

            if (string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()) || string.IsNullOrEmpty(TxtContra.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar todos los campos", "Atencion", MessageBoxButtons.OK);
            }
            else
            {

                Globales.MiUsuario = MiUsuario.ValidarLogin(TxtNombreUsuario.Text.Trim(), TxtContra.Text.Trim());

                if (Globales.MiUsuario.IDUsuario > 0)
                {
                    this.Hide();
                    Globales.MiFromPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Problemas con el usuario o la contrasena", "Atencion", MessageBoxButtons.OK);
                }
            }

            
        }
    }
}
