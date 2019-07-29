using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioVentasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            List<VentaDetalles> lista = new List<VentaDetalles>();

            lista.Add(new VentaDetalles()
            {
                IdProducto = 1,
                Cantidad = 2,
                Precio = 2500
            });

            lista[0].CalularSubTotal();

            Ventas venta = new Ventas()
            {
                IdCliente = 1,
                IdUsuario = 1,
                IdVendedor = 1,
                IdVenta = 0,
                HastaFecha = DateTime.Now.AddDays(5),
                TasaInteres = 5,
                TipoVeta = TiposVentas.Contado,
                Total = 0,
                Detalles = lista
            };


            RepositorioVentas db = new RepositorioVentas();


            Assert.IsTrue(db.Guardar(venta));
     
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }
    }
}