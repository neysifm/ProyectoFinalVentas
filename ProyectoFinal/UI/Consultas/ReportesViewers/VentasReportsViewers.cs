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
    public partial class VentasReportsViewers : MetroFramework.Forms.MetroForm
    {
        private List<Ventas> listado;
        List<VentaView> lista;
        public VentasReportsViewers(List<Ventas> listados)
        {
            InitializeComponent();
            this.listado = listados;
            lista = new List<VentaView>();
            LlenarClase();
            VentaReports reporte = new VentaReports();
            reporte.SetDataSource(lista);
            MycrystalReportViewer.ReportSource = reporte;
            MycrystalReportViewer.Refresh();
        }

        private void LlenarClase()
        {
            RepositorioBase<Ventas> contextoVentas = new RepositorioBase<Ventas>();
            RepositorioBase<Clientes> contextoClientes = new RepositorioBase<Clientes>();
            lista = new List<VentaView>();

            foreach (var item in this.listado)
            {
                Ventas ventas = contextoVentas.Buscar(item.VentaId);
                Clientes clientes = contextoClientes.Buscar(item.ClienteId);
                lista.Add(new VentaView()
                {
                    IdVenta = item.VentaId,
                    Nombre = clientes.Nombres,
                    Fecha = item.Fecha,
                    Total = item.Total
                });

            }
        }
    }
}
