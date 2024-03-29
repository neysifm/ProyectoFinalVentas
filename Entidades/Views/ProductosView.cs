﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Views
{
    public class ProductosView
    {
        public int IdProducto { get; set; }
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }

        public ProductosView()
        {
            IdProducto = 0;
            CategoriaId = 0;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            Cantidad = 0;
            Precio = 0;
            SubTotal = 0;
        }

        public void CalcularTotal()
        {
            SubTotal = Precio * Cantidad;
        }
    }
}
