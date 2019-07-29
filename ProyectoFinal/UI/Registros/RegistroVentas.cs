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
    public partial class RegistroVentas : MetroFramework.Forms.MetroForm, IFormularioRegistros<Ventas>
    {
        public RegistroVentas()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            IDnumericUpDown.Value = 0;
            IDProductosnumericUpDown.Value = 0;
            IDClientenumericUpDown.Value = 0;
            NombreClientemetroTextBox.Clear();
            MontometroTextBox.Clear();
            BalancemetroTextBox.Clear();
            ITBISnumericUpDown.Value = 0;
            FechametroDateTime.Value = DateTime.Now;
            NombreProductometroTextBox.Clear();
            CantidadnumericUpDown.Value = 0;
        }

        public void LlenaCampos(Ventas ventas)
        {
            IDnumericUpDown.Value = ventas.VentaId;
            ITBISnumericUpDown.Value = ventas.ITBIS;
            IDClientenumericUpDown.Value = ventas.ClienteId;
            MontometroTextBox.Text = ventas.Monto.ToString();
            BalancemetroTextBox.Text = ventas.Balance.ToString();
            FechametroDateTime.Value = ventas.Fecha;
        }
        public void LlenaCamposClientes(Clientes clientes)
        {
            IDClientenumericUpDown.Value = clientes.ClienteId;
            NombreClientemetroTextBox.Text = clientes.Nombres;
        }
        public void LlenaCamposProductos(Productos productos)
        {
            IDProductosnumericUpDown.Value = productos.ProductoId;
            NombreProductometroTextBox.Text = productos.Nombre;
        }

        public Ventas LlenaClase()
        {
            throw new NotImplementedException();
        }

        public bool ValidarBuscar()
        {
            if (IDnumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Productos>().Buscar(Convert.ToInt32(IDnumericUpDown.Value)) == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarBuscarCliente()
        {
            if (IDClientenumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Clientes>().Buscar(Convert.ToInt32(IDClientenumericUpDown.Value)) == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarBuscarProducto()
        {
            if (IDProductosnumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Productos>().Buscar(Convert.ToInt32(IDProductosnumericUpDown.Value)) == null)
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

        private void BuscarVentametroButton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscar())
            {
                Ventas ventas = new RepositorioBase<Ventas>().Buscar(Convert.ToInt32(IDnumericUpDown.Value));
                LlenaCampos(ventas);
            }
            else
            {
                MessageBox.Show("No se encontro la venta", "Debe Registrarla!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarClientemetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarCliente())
            {
                Clientes cliente = new RepositorioBase<Clientes>().Buscar(Convert.ToInt32(IDClientenumericUpDown.Value));
                LlenaCamposClientes(cliente);
            }
            else
            {
                MessageBox.Show("No se encontro El Cliente", "Debe Registrarlo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarProductometroButton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarProducto())
            {
                Productos productos = new RepositorioBase<Productos>().Buscar(Convert.ToInt32(IDProductosnumericUpDown.Value));
                LlenaCamposProductos(productos);
            }
            else
            {
                MessageBox.Show("No se encontro El Producto", "Debe Registrarlo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            _ = new Ventas();
            Ventas ventas = LlenaClase();
            RepositorioBase<Ventas> contexto = new RepositorioBase<Ventas>();
            try
            {
                if (IDnumericUpDown.Value == 0)
                {
                    if (contexto.Guardar(ventas))
                    {
                        MessageBox.Show("Se Guardo correctamente", "Registrada la venta!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", "Ups!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (contexto.Modificar(ventas))
                    {
                        MessageBox.Show("Modificado correctamente", "Registrada la venta!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
