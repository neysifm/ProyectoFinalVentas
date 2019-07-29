using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositorioVentas : RepositorioBase<Ventas>
    {
        internal new Contexto contexto;

        // METODO GUARDAR
        public override bool Guardar(Ventas entity)
        {
            contexto = new Contexto();

            bool paso = false;

            RepositorioBase<Productos> conextoProducto = new RepositorioBase<Productos>();
            _ = new Productos();

            foreach (var item in entity.DetalleVenta)
            {
                Productos producto = conextoProducto.Buscar(item.ProductoId);
                producto.Stock -= item.Cantidad;
                conextoProducto.Modificar(producto);
            }

            try
            {
                if (contexto.Venta.Add(entity) != null)
                {
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)

            {
                throw;
            }
            return paso;
        }

        // METODO MODIFICAR
        public override bool Modificar(Ventas entity)
        {
            bool paso = false;

            contexto = new Contexto();

            Contexto contexto1 = new Contexto();
            RepositorioBase<Productos> contextoProductos = new RepositorioBase<Productos>();
            RepositorioBase<DetalleVentas> contextoVentas = new RepositorioBase<DetalleVentas>();

            try
            {
                var temp = contexto1.Venta.Find(entity.VentaId);

                foreach (var item in temp.DetalleVenta)
                {
                    if (!entity.DetalleVenta.Any(D => D.DetalleVentaId == item.DetalleVentaId))
                    {
                        Productos producto = contextoProductos.Buscar(item.ProductoId);
                        producto.Stock += item.Cantidad;
                        contextoProductos.Modificar(producto);
                        contextoVentas.Eliminar(item.DetalleVentaId);
                    }
                }

                foreach (var item in entity.DetalleVenta)
                {
                    if (item.DetalleVentaId == 0)
                    {
                        item.VentaId = entity.VentaId;
                        contextoVentas.Guardar(item);
                    }
                    else
                    {
                        contextoVentas.Modificar(item);
                    }
                }
                contexto.Entry(entity).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        // METODO BUSCAR
        public override Ventas Buscar(int id)
        {
            contexto = new Contexto();
            Ventas venta;

            try
            {
                venta = contexto.Venta.Find(id);
                if (venta != null)
                    venta.DetalleVenta.Count();
            }
            catch (Exception)
            {
                throw;
            }
            return venta;
        }

        // METODO ELIMINAR
        public override bool Eliminar(int id)
        {
            bool paso = false;

            contexto = new Contexto();
            RepositorioBase<Productos> contextoProductos = new RepositorioBase<Productos>();
            RepositorioBase<DetalleVentas> contextoVentas = new RepositorioBase<DetalleVentas>();

            try
            {
                Ventas eliminar = contexto.Venta.Find(id);

                if (eliminar != null)
                {
                    List<DetalleVentas> lista = contextoVentas.GetList(V => V.VentaId == id);

                    contexto.Entry(eliminar).State = EntityState.Deleted;

                    paso = contexto.SaveChanges() > 0;

                    foreach (var item in lista)
                    {
                        Productos producto = contextoProductos.Buscar(item.ProductoId);
                        producto.Stock += item.Cantidad;
                        contextoProductos.Modificar(producto);
                    }
                }
                else
                    return paso;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
    }
}
