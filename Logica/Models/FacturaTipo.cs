using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaTipo
    {

        public int IDFacturaTipo { get; set; }
        public string TipoFactura { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            DataTable Consulta = MiCnn.EjecutarSelect("SPFacturaTipoListar");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = Consulta;
            }

            return R;
        }

    }
}
