using ProyectoFinal.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios RegUsu = new RegistroUsuarios();
            RegUsu.ShowDialog();
        }

        private void RegistroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes RegCl = new RegistroClientes();
            RegCl.ShowDialog();
        }

        private void RegistroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProductos RegPro = new RegistroProductos();
            RegPro.ShowDialog();
        }

        private void RegistroDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCategorias RegCt = new RegistroCategorias();
            RegCt.ShowDialog();
        }

        private void RegistroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVentas RegVen = new RegistroVentas();
            RegVen.ShowDialog();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe ayuda = new AcercaDe();
            ayuda.ShowDialog();
        }
    }
}
