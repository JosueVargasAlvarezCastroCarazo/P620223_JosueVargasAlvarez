using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasennia { get; set; }
        public string CodigoRecuperacion { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        public Empresa MiEmpresa { get; set; }
        public UsuarioRol MiUsuarioRol { get; set; }

        public Usuario()
        {
            MiEmpresa = new Empresa();
            MiUsuarioRol = new UsuarioRol();
            Activo = true;
        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuarioRol", this.MiUsuarioRol.IDUsuarioRol));
            MiCnn.ListaParametros.Add(new SqlParameter("@Empresa", this.MiEmpresa.IDEmpresa));

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioConsultarEmail");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Modificar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public Usuario ConsultarPorID()
        {
            Usuario R = new Usuario();

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula",this.Cedula));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarCedula");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorNombreUsuario()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarNombreUsuario");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarEmail");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();



            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();



            return R;
        }

        public bool ValidarLogin(
            string NombreUsuario, 
            string Contrasennia
            )
        {
            bool R = false;

            return R;
        }

        public bool EnviarCodigoRecuperacion(
            string Email
            )
        {

            bool R = false;

            return R;

        }

        public bool ResetearContrasennia()
        {
            bool R = false;

            return R;
        }



    }
}
