using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int Stock { get; set; }
        public Decimal Costo { get; set; }
        public Decimal ITBIS { get; set; }
        public Decimal Precio { get; set; }
        public DateTime Fecha { get; set; }

        public Productos(int productoId, int categoriaId, string nombre, string descripcion, int stock, decimal costo, decimal iTBIS, decimal precio, DateTime fecha)
        {
            ProductoId = productoId;
            CategoriaId = categoriaId;
            Nombre = nombre;
            Descripcion = descripcion;
            Stock = stock;
            Costo = costo;
            ITBIS = iTBIS;
            Precio = precio;
            Fecha = fecha;
        }

        public Productos()
        {
            ProductoId = 0;
            CategoriaId = 0;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            Stock = 0;
            Costo = 0;
            ITBIS = 0;
            Precio = 0;
            Fecha = DateTime.Now;
        }
    }
}
