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

    }
}
