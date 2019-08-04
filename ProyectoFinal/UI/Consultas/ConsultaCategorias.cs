﻿using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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

                        case 2://Descripcion
                            listado = db.GetList(U => U.Descripcion.Contains(CriteriometroTextBox.Text));
                            break;
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                listado = db.GetList(p => true);
            }
            if (FechacheckBox.Checked)
            {
                listado = listado.Where(U => U.Fecha >= DesdemetroDateTime.Value.Date && U.Fecha <= HastametroDateTime.Value.AddDays(1).Date).ToList();
            }

            ConsultadataGridView.DataSource = listado;
        }

        private void DesdemetroDateTime_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void HastametroDateTime_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FiltrometroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CriteriometroTextBox_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BuscarmetroButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
