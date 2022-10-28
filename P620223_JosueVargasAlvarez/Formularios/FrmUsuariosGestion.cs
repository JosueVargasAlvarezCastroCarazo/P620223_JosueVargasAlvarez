using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_JosueVargasAlvarez.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }
        private Logica.Models.UsuarioRol MiUsuarioRolLocal { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFromPrincipal;
            CargarRolesUsuario();
            CargarEmpresas();

            DgvLista.DataSource = MiUsuarioLocal.Listar();
            
        }

        private void CargarRolesUsuario()
        {
            MiUsuarioRolLocal = new Logica.Models.UsuarioRol();
            DataTable Data = MiUsuarioRolLocal.Listar();

            if (Data!= null && Data.Rows.Count > 0)
            {
                CboxRol.ValueMember = "IDUsuarioRol";
                CboxRol.DisplayMember = "Rol";
                CboxRol.DataSource = Data;
                CboxRol.SelectedIndex = -1;
            }

        }

        private void CargarEmpresas()
        {
            DataTable Data = new Logica.Models.Empresa().Listar();

            if (Data != null && Data.Rows.Count > 0)
            {
                CboxEmpresa.ValueMember = "id";
                CboxEmpresa.DisplayMember = "nombre";
                CboxEmpresa.DataSource = Data;
                CboxEmpresa.SelectedIndex = -1;
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposRequeridos())
            {

                MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
                MiUsuarioLocal.NombreUsuario = TxtNombreUsuario.Text.Trim();
                MiUsuarioLocal.Email = TxtCorreo.Text.Trim();
                MiUsuarioLocal.Contrasennia = TxtContrasena.Text.Trim();
                MiUsuarioLocal.MiUsuarioRol.IDUsuarioRol = (int)CboxRol.SelectedValue;
                MiUsuarioLocal.MiEmpresa.IDEmpresa = (int)CboxEmpresa.SelectedValue;


                if (
                    !MiUsuarioLocal.ConsultarPorCedula() && 
                    !MiUsuarioLocal.ConsultarPorEmail() && 
                    !MiUsuarioLocal.ConsultarPorNombreUsuario()
                    )
                {

                    DialogResult respuesta = MessageBox.Show("Seguro desea agregar al usuario","Atencion",MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Agregar())
                        {
                            MessageBox.Show("Usuario agregado", "Atencion", MessageBoxButtons.OK);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no agregado por problemas", "Atencion", MessageBoxButtons.OK);
                        }
                    }

       
                }
                else
                {
                    if (MiUsuarioLocal.ConsultarPorCedula())
                    {
                        MessageBox.Show("Ya existe esta cedula en el sistema", "Atencion", MessageBoxButtons.OK);
                    }
                    else if (MiUsuarioLocal.ConsultarPorEmail())
                    {
                        MessageBox.Show("Ya existe este email en el sistema", "Atencion", MessageBoxButtons.OK);
                    }
                    else if (MiUsuarioLocal.ConsultarPorNombreUsuario())
                    {
                        MessageBox.Show("Ya existe este nombre de usuario en el sistema", "Atencion", MessageBoxButtons.OK);
                    }
                }
            }
            
        }

        private bool ValidarCamposRequeridos()
        {
            bool R = false;

            if (
                !string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasena.Text.Trim()) &&
                CboxEmpresa.SelectedIndex > -1 &&
                CboxRol.SelectedIndex > -1
                )
            {
                R = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los espacios","Atencion",MessageBoxButtons.OK);
            }

            return R;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtCedula.Clear();
            TxtNombreUsuario.Clear();
            TxtCorreo.Clear();
            TxtContrasena.Clear();
            CboxEmpresa.SelectedIndex = -1;
            CboxRol.SelectedIndex = -1;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e,true);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DgvLista.DataSource = MiUsuarioLocal.Listar(CbVerActivos.Checked, TxtBuscar.Text.Trim());
        }
    }
}
