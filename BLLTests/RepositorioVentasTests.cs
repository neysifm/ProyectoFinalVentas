using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioVentasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            List<DetalleVentas> lista = new List<DetalleVentas>();

            lista.Add(new DetalleVentas()
            {
                ProductoId = 1,
                Cantidad = 2,
                Precio = 200
            });

            lista[0].CalularSubTotal();

            Ventas venta = new Ventas()
            {
                ClienteId = 1,
                VentaId = 1,
                ITBIS = 3,
                Monto = 300,
                Balance = 500,
                Fecha = DateTime.Now.AddDays(2),
                DetalleVenta = lista
            };
            RepositorioVentas contexto = new RepositorioVentas();
            Assert.IsTrue(contexto.Guardar(venta));
        }
    }
}