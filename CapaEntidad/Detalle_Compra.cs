using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Compra
    {
        public int IdDetalle_Compra { get; set; }
        public Producto oProducto { get; set; }
        public decimal  PrecioVenta { get; set; }
        public decimal  PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal Montototal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
