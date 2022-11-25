using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {

        public int IDFactura { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Notas { get; set; }

        public Cliente MiCliente;
        public Usuario MiUsuario;
        public FacturaTipo MiFacturaTipo;
        public List<FacturaInventario> Detalle;

        public Factura()
        {
            MiCliente = new Cliente();
            MiUsuario = new Usuario();
            MiFacturaTipo = new FacturaTipo();
            Detalle = new List<FacturaInventario>();
            Fecha = DateTime.Now;
        }

        public int Agregar()
        {
            int R = 0;

            return R;
        }

        public bool Imprimir()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarPorFechas(
            DateTime FechaInicial, 
            DateTime FechaFinal
            )
        {
            DataTable R = new DataTable();



            return R;
        }

        public DataTable CargarSchemaListaDetalle(
 
            )
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            DataTable Consulta = MiCnn.EjecutarSelect("SPFacturaDetalleSchema", true);
            R = Consulta;
            R.PrimaryKey = null;

            return R;
        }

    }
}
