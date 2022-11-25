using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {

        public int IDCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        public Empresa MiEmpresa { get; set; }

        public Cliente()
        {
            MiEmpresa = new Empresa();
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

        public Cliente ConsultarPorID()
        {
            Cliente R = new Cliente();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@Id", this.IDCliente));

            DataTable Consulta = MiCnn.EjecutarSelect("SPClienteConsultarId");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                DataRow Fila = Consulta.Rows[0];
                R.IDCliente = (int)Fila["IdCliente"];
                R.Cedula = (string)Fila["Cedula"];
                R.Nombre = (string)Fila["Nombre"];
                R.CorreoElectronico = (string)Fila["CorreoElectronico"];
                R.Telefono = (string)Fila["Telefono"];
                R.Direccion = (string)Fila["Direccion"];
                R.Activo = (bool)Fila["Activo"];
                R.MiEmpresa.IDEmpresa = (int)Fila["IDEmpresa"];
            }

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool VerActivos = true,string Busqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Busqueda", Busqueda));

            DataTable Consulta = MiCnn.EjecutarSelect("SPClienteListar");


            R = Consulta;


            return R;
        }
    }
}
