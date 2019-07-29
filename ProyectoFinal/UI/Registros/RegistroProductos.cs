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
    public partial class RegistroProductos : MetroFramework.Forms.MetroForm, IFormularioRegistros<Productos>
    {
        public RegistroProductos()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            IDProductonumericUpDown.Value = 0;
            IDCategorianumericUpDown.Value = 0;
            NombremetroTextBox.Clear();
            DescripcionProductometroTextBox.Clear();
            ITBISnumericUpDown.Value = 0;
            CostonumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            //StockmetroTextBox.Clear();
            FechametroDateTime.Value = DateTime.Now;
            DescripcionCategoriametroTextBox.Clear();
        }

        public void LlenaCampos(Productos productos)
        {
            IDProductonumericUpDown.Value = productos.ProductoId;
            NombremetroTextBox.Text = productos.Nombre;
            DescripcionProductometroTextBox.Text = productos.Descripcion;
            ITBISnumericUpDown.Value = productos.ITBIS;
            CostonumericUpDown.Value = productos.Costo;
            PrecionumericUpDown.Value = productos.Precio;
            StockmetroTextBox.Text = productos.Stock.ToString();
            FechametroDateTime.Value = productos.Fecha;
        }

        public void LlenaCamposCategoria(Categorias categorias)
        {
            IDCategorianumericUpDown.Value = categorias.CategoriaId;
            DescripcionCategoriametroTextBox.Text = categorias.Descripcion;
        }

        public Productos LlenaClase()
        {
            Productos productos = new Productos()
            {
                ProductoId = Convert.ToInt32(IDProductonumericUpDown.Value),
                Nombre = NombremetroTextBox.Text,
                Descripcion = DescripcionProductometroTextBox.Text,
                ITBIS = Convert.ToInt32(ITBISnumericUpDown.Value),
                Costo = Convert.ToInt32(CostonumericUpDown.Value),
                Precio = Convert.ToInt32(PrecionumericUpDown.Value),
                Stock = Convert.ToInt32(StockmetroTextBox.Text),
                Fecha = FechametroDateTime.Value,
            };
            return productos;
        }

        public bool ValidarBuscar()
        {
            if (IDProductonumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Productos>().Buscar(Convert.ToInt32(IDProductonumericUpDown.Value)) == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarBuscarCategoria()
        {
            if (IDCategorianumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Categorias>().Buscar(Convert.ToInt32(IDCategorianumericUpDown.Value)) == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarCampos()
        {
            throw new NotImplementedException();
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

        private void BuscarProductometroButton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscar())
            {
                Productos productos = new RepositorioBase<Productos>().Buscar(Convert.ToInt32(IDProductonumericUpDown.Value));
                LlenaCampos(productos);
            }
            else
            {
                MessageBox.Show("No se encontro el Producto", "Debe Registrarlo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarCategoriametroButton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarCategoria())
            {
                Categorias categorias = new RepositorioBase<Categorias>().Buscar(Convert.ToInt32(IDCategorianumericUpDown.Value));
                LlenaCamposCategoria(categorias);
            }
            else
            {
                MessageBox.Show("No se encontro el Cliente", "Debe Registrarse!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgregarCategoriametroButton_Click(object sender, EventArgs e)
        {
            RegistroCategorias RegCat = new RegistroCategorias();
            RegCat.ShowDialog();
        }

        private void NuevometroButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarmetroButton_Click(object sender, EventArgs e)
        {
            if (!ValidarGuardar())
                return;
            _ = new Productos();
            Productos productos = LlenaClase();
            RepositorioBase<Productos> contexto = new RepositorioBase<Productos>();
            try
            {
                if (IDProductonumericUpDown.Value == 0)
                {
                    if (contexto.Guardar(productos))
                    {
                        MessageBox.Show("Se Guardo correctamente", "Registrado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", "Ups!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (contexto.Modificar(productos))
                    {
                        MessageBox.Show("Modificado correctamente", "Registrado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                new RepositorioBase<Productos>().Eliminar(Convert.ToInt32(IDProductonumericUpDown.Value));
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
