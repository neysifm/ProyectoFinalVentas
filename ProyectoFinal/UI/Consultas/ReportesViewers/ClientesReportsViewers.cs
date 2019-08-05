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
    public partial class ClientesReportsViewers : MetroFramework.Forms.MetroForm
    {
        private List<Clientes> listado;
        public ClientesReportsViewers(List<Clientes> listados)
        {
            InitializeComponent();
            this.listado = listados;
            ClienteReports reporte = new ClienteReports();
            reporte.SetDataSource(listado);
            MycrystalReportViewer.ReportSource = reporte;
            MycrystalReportViewer.Refresh();
        }
    }
}
