using System;
using System.Collections.Generic;
using System.Data;
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

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();



            return R;
        }
    }
}
