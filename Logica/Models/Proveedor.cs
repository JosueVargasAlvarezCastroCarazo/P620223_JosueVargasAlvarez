using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {

        public int IDProveedor { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }

        public Proveedor()
        {
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

        public bool ConsultarPorID()
        {
            bool R = false;

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
