using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Views
{
    public class VentaView
    {
        public int IdVenta { get; set; }
        public string Nombre { get; set; }
        public string Expr1 { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HastaFecha { get; set; }
        public decimal Total { get; set; }

        public VentaView()
        {
            IdVenta = 0;
            Nombre = string.Empty;
            Expr1 = string.Empty;
            Fecha = DateTime.Now;
            HastaFecha = DateTime.Now;
            Total = 0;
        }
    }
}
