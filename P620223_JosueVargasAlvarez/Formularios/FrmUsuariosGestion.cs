using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                            DgvLista.DataSource = MiUsuarioLocal.Listar();
                            DgvLista.ClearSelection();
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
                if (
                    Regex.Match(TxtCorreo.Text.Trim(), "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$").Success
                )
                {

                    if (
                        Regex.Match(TxtContrasena.Text.Trim(), "^(?=.*\\d)(?=.*[\\u0021-\\u002b\\u003c-\\u0040])(?=.*[A-Z])(?=.*[a-z])\\S{8,16}$").Success
                        )
                    {
                    
                        R = true;
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no respeta el patron", "Atencion", MessageBoxButtons.OK);
                    }


                    
                }
                else
                {
                    MessageBox.Show("Debe ingresar un correo valido", "Atencion", MessageBoxButtons.OK);
                }

                
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los espacios","Atencion",MessageBoxButtons.OK);
            }

            return R;
        }

        private bool ValidarCamposRequeridosModificar()
        {
            bool R = false;

            if (
                !string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCorreo.Text.Trim()) &&
                CboxEmpresa.SelectedIndex > -1 &&
                CboxRol.SelectedIndex > -1
                )
            {
                if (
                    Regex.Match(TxtCorreo.Text.Trim(), "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$").Success
                )
                {

                    R = true;
                  
                }
                else
                {
                    MessageBox.Show("Debe ingresar un correo valido", "Atencion", MessageBoxButtons.OK);
                }


            }
            else
            {
                MessageBox.Show("Debe ingresar todos los espacios", "Atencion", MessageBoxButtons.OK);
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
            BtnEliminar.Text = "Eliminar";
            CbVerActivos.Checked = true;

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

        private void BtnVer_Click(object sender, EventArgs e)
        {
            TxtContrasena.UseSystemPasswordChar = !TxtContrasena.UseSystemPasswordChar;
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                Limpiar();
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];

                int IdUsuario = (int)MiFila.Cells["CIDUsuario"].Value;
                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal.IDUsuario = IdUsuario;
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID();

                if (MiUsuarioLocal != null && MiUsuarioLocal.IDUsuario > 0)
                {
                    TxtCodigo.Text = MiUsuarioLocal.IDUsuario.ToString();
                    TxtNombre.Text = MiUsuarioLocal.Nombre.ToString();
                    TxtCedula.Text = MiUsuarioLocal.Cedula.ToString();
                    TxtNombreUsuario.Text = MiUsuarioLocal.NombreUsuario.ToString();
                    TxtCorreo.Text = MiUsuarioLocal.Email.ToString();
                    
                    CboxEmpresa.SelectedValue = MiUsuarioLocal.MiEmpresa.IDEmpresa;
                    CboxRol.SelectedValue = MiUsuarioLocal.MiUsuarioRol.IDUsuarioRol;
                    CbActivo.Checked = MiUsuarioLocal.Activo;

                    if (MiUsuarioLocal.Activo)
                    {
                        BtnEliminar.Text = "Eliminar";
                    }
                    else
                    {
                        BtnEliminar.Text = "Restaurar";
                    }

                }

            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposRequeridosModificar())
            {

                MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
                MiUsuarioLocal.NombreUsuario = TxtNombreUsuario.Text.Trim();
                MiUsuarioLocal.Email = TxtCorreo.Text.Trim();
                MiUsuarioLocal.Contrasennia = TxtContrasena.Text.Trim();
                MiUsuarioLocal.MiUsuarioRol.IDUsuarioRol = (int)CboxRol.SelectedValue;
                MiUsuarioLocal.MiEmpresa.IDEmpresa = (int)CboxEmpresa.SelectedValue;

                if (MiUsuarioLocal.ConsultarPorID().IDUsuario > 0)
                {
                    DialogResult respuesta = MessageBox.Show("Seguro desea modificar el usuario", "Atencion", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Modificar())
                        {
                            MessageBox.Show("Usuario modificado", "Atencion", MessageBoxButtons.OK);
                            Limpiar();
                            DgvLista.DataSource = MiUsuarioLocal.Listar();
                            DgvLista.ClearSelection();
                            
                        }
                        else
                        {
                            MessageBox.Show("Usuario no modificado por problemas", "Atencion", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ya no existe", "Atencion", MessageBoxButtons.OK);
                }

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiUsuarioLocal.ConsultarPorID().IDUsuario > 0)
            {

                DialogResult respuesta;

                if (MiUsuarioLocal.Activo)
                {
                    respuesta = MessageBox.Show("Seguro desea eliminar el usuario", "Atencion", MessageBoxButtons.YesNo);

                }
                else
                {
                    respuesta = MessageBox.Show("Seguro desea restaurar el usuario", "Atencion", MessageBoxButtons.YesNo);

                }


                if (respuesta == DialogResult.Yes)
                {
                    if (MiUsuarioLocal.Eliminar())
                    {

                        if (MiUsuarioLocal.Activo)
                        {
                            MessageBox.Show("Usuario eliminado", "Atencion", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Usuario restaurado", "Atencion", MessageBoxButtons.OK);
                        }

                           
                        Limpiar();
                        DgvLista.DataSource = MiUsuarioLocal.Listar();
                        DgvLista.ClearSelection();

                    }
                    else
                    {
                        MessageBox.Show("Usuario no eliminado o restaurado por problemas", "Atencion", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario ya no existe", "Atencion", MessageBoxButtons.OK);
            }
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            DgvLista.DataSource = MiUsuarioLocal.Listar(CbVerActivos.Checked);
        }
    }
}
