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
    public partial class UsuariosReportsViewer : MetroFramework.Forms.MetroForm
    {
        private List<Usuarios> listado;
        public UsuariosReportsViewer(List<Usuarios> listados)
        {
            InitializeComponent();
            this.listado = listados;
            UsuarioReports reporte = new UsuarioReports();
            reporte.SetDataSource(listado);
            MycrystalReportViewer.ReportSource = reporte;
            MycrystalReportViewer.Refresh();
        }
    }
}
