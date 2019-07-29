using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVentas
    {
        [Key]
        public int DetalleVentaId { get; set; }
        public int ProductoId { get; set; }
        public int VentaId { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }

        public DetalleVentas(int detalleVentaId, int productoId, int ventaId, int cantidad, decimal precio)
        {
            DetalleVentaId = detalleVentaId;
            ProductoId = productoId;
            VentaId = ventaId;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
