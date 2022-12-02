using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Inventario
    {
        public int IDInventario { get; set; }
        public string NombreItem { get; set; }
        public string CodigoBarras { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CantidadEnStock { get; set; }
        public bool Activo { get; set; }

        public List<InventarioProveedor> ListadoProveedores { get; set; }
        public Empresa MiEmpresa { get; set; }

        public Categoria MiCategoria { get; set; }

        public Impuesto MiImpuesto { get; set; }

        public Inventario()
        {
            ListadoProveedores = new List<InventarioProveedor>();
            MiEmpresa = new Empresa();
            MiCategoria = new Categoria();
            MiImpuesto = new Impuesto();
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

        public Inventario ConsultarPorID()
        {
            Inventario R = new Inventario();

            return R;
        }

        public bool ConsultarPorCodigoBarras(int IDEmpresa)
        {
            bool R = false;

            return R;
        }

        public DataTable ListarProveedores()
        {
            DataTable R = new DataTable();



            return R;
        }

        public bool AgregarProveedor()
        {
            bool R = false;

            return R;
        }

        public bool EliminarProveedor()
        {
            bool R = false;

            return R;
        }

        public bool ModificarPrecioProveedor()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool VerActivos = true, string Busqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Busqueda", Busqueda));

            DataTable Consulta = MiCnn.EjecutarSelect("SPInventarioListar");


            R = Consulta;


            return R;
        }

    }
}
