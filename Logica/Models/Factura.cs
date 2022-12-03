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

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@IDCliente", this.MiCliente.IDCliente));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuario", this.MiUsuario.IDUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDTipoFactura", this.MiFacturaTipo.IDFacturaTipo));
            MiCnn.ListaParametros.Add(new SqlParameter("@Notas", this.Notas));

            Object Resultado = MiCnn.EjecutarConRetornoEscalar("SPFacturaAgregar");

            R = Convert.ToInt32(Resultado.ToString());

            this.IDFactura = R;

            foreach (FacturaInventario item in Detalle)
            {
                Conexion MiCnnDetalle = new Conexion();
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@IDFactura", IDFactura));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@IDInventario", item.MiInventario.IDInventario));
               
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@Costo", item.Costo));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@PrecioVenta", item.PrecioVenta));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@Cantidad", item.Cantidad));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@PorcentajeImpuesto", item.PorcentajeImpuesto));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@PorcentajeDescuento", item.PorcentajeDescuento));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@SubTotal", item.SubTotal));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@DescuentoTotal", item.DescuentoTotal));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@SubTotal2", item.SubTotal2));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@ImpuestosTotal", item.ImpuestosTotal));
                MiCnnDetalle.ListaParametros.Add(new SqlParameter("@TotalLinea", item.TotalLinea));

                MiCnnDetalle.EjecutarUpdateDeleteInsert("SPFacturaAgregarDetalle");


            }


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
