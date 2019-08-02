using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaCategorias : MetroFramework.Forms.MetroForm
    {
        private List<Categorias> listado;
        public ConsultaCategorias()
        {
            InitializeComponent();
            listado = new List<Categorias>();
            FiltrometroComboBox.SelectedIndex = 0;
            Buscar();
        }
        private void Buscar()
        {
            listado = new List<Categorias>();
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            if (CriteriometroTextBox.Text.Trim().Length > 0)
            {
                try
                {
                    switch (FiltrometroComboBox.SelectedIndex)
                    {
                        case 0://Todo
                            listado = db.GetList(U => true);
                            break;

                        case 1://ID
                            int id = int.Parse(CriteriometroTextBox.Text);
                            listado = db.GetList(U => U.CategoriaId == id);
                            break;

                        case 2://Nombre
                            listado = db.GetList(U => U.Descripcion.Contains(CriteriometroTextBox.Text));
                            break;
                    }
                }
                catch (Exception)
                {

                }
            }
            else
                dataGridView1.DataSource = listado;
        }

        private void FechacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void DesdedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void HastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrometroComboBox.SelectedIndex == 4)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
            }
            else
                checkBox1.Enabled = true;

            Buscar();
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
