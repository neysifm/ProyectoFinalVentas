using System;
using System.Collections.Generic;
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
        public virtual List<DetalleVentas> DetalleVenta { get; set; }

        public Ventas(int ventaId, int clienteId, decimal iTBIS, decimal monto, decimal balance, DateTime fecha, List<DetalleVentas> detalleVenta)
        {
            VentaId = ventaId;
            ClienteId = clienteId;
            ITBIS = iTBIS;
            Monto = monto;
            Balance = balance;
            Fecha = fecha;
            DetalleVenta = detalleVenta;
        }
    }
}
