using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaInventario
    {
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal SubTotal { get; set; } // suma de cantidad por precio venta
        public decimal DescuentoTotal { get; set; }
        public decimal SubTotal2 { get; set; }// subtotal - descuentoTotal
        public decimal ImpuestosTotal { get; set; }
        public decimal TotalLinea { get; set; }//subtotal2 + impuesto total


        public Inventario MiInventario { get; set; }
     


        public FacturaInventario()
        {
            MiInventario = new Inventario();
        }

        public decimal TotalizarLinea()
        {
            SubTotal = Cantidad * PrecioVenta;
            DescuentoTotal = (SubTotal * PorcentajeDescuento) / 100;
            SubTotal2 = SubTotal - DescuentoTotal;
            ImpuestosTotal = (SubTotal2 * PorcentajeImpuesto) / 100;
            TotalLinea = SubTotal2 + ImpuestosTotal;
            return TotalLinea;
        }

    }
}
