using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public Decimal ITBIS { get; set; }
        public Decimal Monto { get; set; }
        public Decimal Balance { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Total { get; set; }
        public virtual List<DetalleVentas> DetalleVenta { get; set; }

        public Ventas(int ventaId, int clienteId, decimal iTBIS, decimal monto, decimal balance, DateTime fecha, decimal total, List<DetalleVentas> detalleVenta)
        {
            VentaId = ventaId;
            ClienteId = clienteId;
            ITBIS = iTBIS;
            Monto = monto;
            Balance = balance;
            Fecha = fecha;
            Total = total;
            DetalleVenta = detalleVenta;
        }

        public Ventas()
        {
            VentaId = 0;
            ClienteId = 0;
            ITBIS = 0;
            Monto = 0;
            Balance = 0;
            Total = 0;
            Fecha = DateTime.Now;
            DetalleVenta = new List<DetalleVentas>();
        }
    }
}
