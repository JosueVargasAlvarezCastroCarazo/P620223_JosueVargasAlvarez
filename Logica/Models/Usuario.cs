using P620223_JosueVargasAlvarez;
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
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasennia", new Encriptador().EncriptarEnUnSentido(this.Contrasennia)));
            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuarioRol", this.MiUsuarioRol.IDUsuarioRol));
            MiCnn.ListaParametros.Add(new SqlParameter("@Empresa", this.MiEmpresa.IDEmpresa));

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioAgregar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Modificar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@Id", this.IDUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasennia", new Encriptador().EncriptarEnUnSentido(this.Contrasennia)));
            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuarioRol", this.MiUsuarioRol.IDUsuarioRol));
            MiCnn.ListaParametros.Add(new SqlParameter("@Empresa", this.MiEmpresa.IDEmpresa));

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioActualizar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@Id", this.IDUsuario));

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioEliminar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public Usuario ConsultarPorID()
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@IdUsuario", this.IDUsuario));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarId");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                DataRow Fila = Consulta.Rows[0];
                R.IDUsuario = (int)Fila["IdUsuario"];
                R.Nombre = (string)Fila["Nombre"];
                R.Cedula = (string)Fila["Cedula"];
                R.NombreUsuario = (string)Fila["NombreUsuario"];
                R.Contrasennia = (string)Fila["Contrasennia"];
                R.Email = (string)Fila["Email"];
                R.MiUsuarioRol.IDUsuarioRol = (int)Fila["IdUsuarioRol"];
                R.MiEmpresa.IDEmpresa = (int)Fila["IdEmpresa"];
                R.Activo = (bool)Fila["Activo"];
            }

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

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

        public DataTable Listar(bool VerActivos = true,string Busqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Busqueda", Busqueda));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioListar");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = Consulta;
            }

            return R;
        }

        public Usuario ValidarLogin(
            string NombreUsuario, 
            string Contrasennia
            )
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", NombreUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@Contra", new Encriptador().EncriptarEnUnSentido(Contrasennia)));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioLogin");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                DataRow Fila = Consulta.Rows[0];
                R.IDUsuario = (int)Fila["IdUsuario"];
                R = R.ConsultarPorID();
            }

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
