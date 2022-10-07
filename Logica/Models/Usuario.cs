using System;
using System.Collections.Generic;
using System.Data;
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

            return R;
        }

        public bool ConsultarPorNombreUsuario()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

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
