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

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroCategorias : MetroFramework.Forms.MetroForm, IFormularioRegistros<Categorias>
    {
        public RegistroCategorias()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            IDnumericUpDown.Value = 0;
            CategoriametroTextBox.Clear();
        }

        public void LlenaCampos(Categorias categorias)
        {
            IDnumericUpDown.Value = categorias.CategoriaId;
            CategoriametroTextBox.Text = categorias.Descripcion;
        }

        public Categorias LlenaClase()
        {
            Categorias categorias = new Categorias()
            {
                CategoriaId = Convert.ToInt32(IDnumericUpDown.Value),
                Descripcion = CategoriametroTextBox.Text,
            };
            return categorias;
        }

        public bool ValidarBuscar()
        {
            if (IDnumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Categorias>().Buscar(Convert.ToInt32(IDnumericUpDown.Value)) == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarCampos()
        {
            bool validar = true;

            if (string.IsNullOrEmpty(CategoriametroTextBox.Text))
            {
                errorProvider.SetError(CategoriametroTextBox, "La Descripcion de la Categoria no puede estar vacia, Llenar Descripcion");
                validar = false;
            }
            return validar;
        }

        public bool ValidarEliminar()
        {
            return ValidarBuscar();
        }

        public bool ValidarGuardar()
        {
            if (!ValidarCampos())
            {
                return false;
            }
            return true;
        }

        public bool ValidarModificar()
        {
            if (!ValidarBuscar() || !ValidarGuardar())
            {
                return false;
            }
            return true;
        }

        private void BuscarmetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscar())
            {
                Categorias categorias = new RepositorioBase<Categorias>().Buscar(Convert.ToInt32(IDnumericUpDown.Value));
                LlenaCampos(categorias);
            }
            else
            {
                MessageBox.Show("No se encontro la Categoria", "Debe Registrarla!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NuevometroButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarmetroButton_Click(object sender, EventArgs e)
        {
            if (!ValidarGuardar())
                return;
            _ = new Categorias();
            Categorias categorias = LlenaClase();
            RepositorioBase<Categorias> contexto = new RepositorioBase<Categorias>();
            try
            {
                if (IDnumericUpDown.Value == 0)
                {
                    if (contexto.Guardar(categorias))
                    {
                        MessageBox.Show("Se Guardo correctamente", "Registrada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", "Ups!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (contexto.Modificar(categorias))
                    {
                        MessageBox.Show("Modificado correctamente", "Registrada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar", "Ups!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Ups!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarmetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarEliminar())
            {
                new RepositorioBase<Categorias>().Eliminar(Convert.ToInt32(IDnumericUpDown.Value));
                LimpiarCampos();
                MessageBox.Show("El Registro se Elimino Correctamente!");
            }
            else
            {
                MessageBox.Show("No se Pudo Eliminar el registro");
            }
        }
    }
}
