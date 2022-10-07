using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Impuesto
    {

        public int IDImpuesto { get; set; }
        public string CodigoImpuesto { get; set; }
        public string NombreImpuesto { get; set; }
        public decimal TasaImpuesto { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();



            return R;
        }

    }
}
