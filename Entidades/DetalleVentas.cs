using System;
using System.ComponentModel.DataAnnotations;

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
        public Decimal Subtotal { get; set; }

        public DetalleVentas(int detalleVentaId, int productoId, int ventaId, int cantidad, decimal precio, decimal subtotal)
        {
            DetalleVentaId = detalleVentaId;
            ProductoId = productoId;
            VentaId = ventaId;
            Cantidad = cantidad;
            Precio = precio;
            Subtotal = subtotal;
        }

        public DetalleVentas()
        {
            DetalleVentaId = 0;
            ProductoId = 0;
            VentaId = 0;
            Cantidad = 0;
            Precio = 0;
            Subtotal = 0;
        }

        public void CalularSubTotal()
        {
            Subtotal = Precio * Cantidad;
        }
    }
}
