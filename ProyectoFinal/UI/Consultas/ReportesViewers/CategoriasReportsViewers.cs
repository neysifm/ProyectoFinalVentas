using Entidades;
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
    public partial class CategoriasReportsViewers : MetroFramework.Forms.MetroForm
    {
        private List<Categorias> listado;
        public CategoriasReportsViewers(List<Categorias> listados)
        {
            InitializeComponent();
            this.listado = listados;
            CategoriaReports reporte = new CategoriaReports();
            reporte.SetDataSource(listado);
            MycrystalReportViewer.ReportSource = reporte;
            MycrystalReportViewer.Refresh();
        }
    }
}
