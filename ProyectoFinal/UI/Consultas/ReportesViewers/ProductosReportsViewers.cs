using BLL;
using Entidades;
using Entidades.Views;
using ProyectoFinal.UI.Consultas.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas.ReportesViewers
{
    public partial class ProductosReportsViewers : MetroFramework.Forms.MetroForm
    {
        private List<Productos> listado;
        List<ProductosView> lista;
        public ProductosReportsViewers(List<Productos> listados)
        {
            InitializeComponent();
            this.listado = listados;
            lista = new List<ProductosView>();
            LlenarClase();
            ProductoReports reporte = new ProductoReports();
            reporte.SetDataSource(lista);
            MycrystalReportViewer.ReportSource = reporte;
            MycrystalReportViewer.Refresh();
        }

        private void LlenarClase()
        {
            RepositorioBase<Productos> contextoProducto = new RepositorioBase<Productos>();
            RepositorioBase<Categorias> contextoCategorias = new RepositorioBase<Categorias>();
            lista = new List<ProductosView>();

            foreach (var item in this.listado)
            {
                Productos producto = contextoProducto.Buscar(item.ProductoId);
                Categorias categorias = contextoCategorias.Buscar(item.CategoriaId);
                lista.Add(new ProductosView()
                {
                    IdProducto = item.ProductoId,
                    CategoriaId = item.CategoriaId,
                    Nombre = item.Nombre,
                    Descripcion = item.Descripcion,
                    Cantidad = item.Stock,
                    Precio = item.Precio,
                    SubTotal = item.Costo,
                });

            }
        }
    }
}
