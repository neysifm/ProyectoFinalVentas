using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroVentas : MetroFramework.Forms.MetroForm, IFormularioRegistros<Ventas>
    {
        List<DetalleVentas> listaVentas = new List<DetalleVentas>();
        public RegistroVentas()
        {
            InitializeComponent();
            EliminarFilametroButton.Enabled = false;
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
            CantidadnumericUpDown.Value = CantidadnumericUpDown.Minimum;
            CantidadnumericUpDown.Maximum = 100;
            this.listaVentas = null;
            ActualizarGrid();
            metroTextBoxStock.Clear();
            habilitarBotones(true);
        }

        public void LlenaCampos(Ventas ventas)
        {
            IDnumericUpDown.Value = ventas.VentaId;
            ITBISnumericUpDown.Value = ventas.ITBIS;
            IDClientenumericUpDown.Value = ventas.ClienteId;
            Clientes cliente = new RepositorioBase<Clientes>().Buscar(ventas.ClienteId);
            if (cliente != null)
            {
                NombreClientemetroTextBox.Text = cliente.Nombres;
                BalancemetroTextBox.Text = cliente.Balance.ToString();
            }
            MontometroTextBox.Text = ventas.Monto.ToString();
            FechametroDateTime.Value = ventas.Fecha;
            if (ventas.DetalleVenta != null && ventas.DetalleVenta.Count > 0)
            {
                this.listaVentas = ventas.DetalleVenta;
                ActualizarGrid();
            }
            habilitarBotones(false);
        }

        private void habilitarBotones(bool estado)
        {
            IDnumericUpDown.Enabled = estado;
            IDClientenumericUpDown.Enabled = estado;
            ITBISnumericUpDown.Enabled = estado;
            IDProductosnumericUpDown.Enabled = estado;
        }

        public void LlenaCamposClientes(Clientes clientes)
        {
            IDClientenumericUpDown.Value = clientes.ClienteId;
            NombreClientemetroTextBox.Text = clientes.Nombres;
            BalancemetroTextBox.Text = clientes.Balance.ToString();
        }
        public void LlenaCamposProductos(Productos productos)
        {
            IDProductosnumericUpDown.Value = productos.ProductoId;
            NombreProductometroTextBox.Text = productos.Nombre;
            metroTextBoxStock.Text = productos.Stock.ToString();
            CantidadnumericUpDown.Maximum = productos.Stock;
        }

        public Ventas LlenaClase()
        {
            decimal monto = 0;
            foreach (DetalleVentas d in listaVentas)
            {
                d.CalularSubTotal();
                monto += d.Subtotal;
            }
            Ventas ventas = new Ventas()
            {
                VentaId = Convert.ToInt32(IDnumericUpDown.Value),
                ClienteId = Convert.ToInt32(IDClientenumericUpDown.Value),
                ITBIS = Convert.ToInt32(this.ITBISnumericUpDown.Value),
                Monto = monto,
                Balance = monto,
                DetalleVenta = listaVentas
            };

            return ventas;
        }

        public bool ValidarBuscar()
        {
            if (IDnumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Ventas>().Buscar(Convert.ToInt32(IDnumericUpDown.Value)) == null)
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
            bool validar = true;

            if (string.IsNullOrEmpty(NombreClientemetroTextBox.Text))
            {
                errorProvider.SetError(NombreClientemetroTextBox, "El nombre no puede estar vacio, Llenar Nombre");
                validar = false;
            }

            if (listaVentas.Count <= 0)
            {
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

        private void BuscarVentametroButton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscar())
            {
                Ventas ventas = new RepositorioBase<Ventas>().Buscar(Convert.ToInt32(IDnumericUpDown.Value));
                if (ventas == null)
                {
                    MessageBox.Show("No se encontro la venta", "Debe Registrarla!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    LlenaCampos(ventas);
                }

            }
            else
            {
                MessageBox.Show("Datos Invalidos");
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

            RepositorioVentas contexto = new RepositorioVentas();
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




        private void AgregarProductometroButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDProductosnumericUpDown.Value);
            int cantidad = Convert.ToInt32(this.CantidadnumericUpDown.Value);
            Productos producto = new RepositorioBase<Productos>().Buscar(id);
            DetalleVentas detalleVenta = new DetalleVentas();
            detalleVenta.Precio = producto.Precio;
            detalleVenta.Cantidad = cantidad;
            detalleVenta.ProductoId = id;

            listaVentas.Add(detalleVenta);
            ActualizarGrid();

        }

        private void ActualizarGrid()
        {
            this.DetalledataGridView.DataSource = null;
            this.DetalledataGridView.DataSource = listaVentas;
            this.DetalledataGridView.Update();
            ActualizarMonto();
        }

        private void ActualizarMonto()
        {

            decimal monto = 0;
            int i = 0;
            if (listaVentas == null)
            {
                return;
            }
            foreach (var item in listaVentas)
            {
                int cantidad = item.Cantidad;
                item.CalularSubTotal();
                monto += item.Subtotal;
            }

            this.MontometroTextBox.Text = monto.ToString();
            this.TotalmetroTextBox.Text = monto.ToString();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
        }

        private void EliminarFilametroButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                if (listaVentas.Count > 0)
                {
                    if (DetalledataGridView.SelectedCells.Count > 0)
                    {
                        listaVentas.RemoveAt(DetalledataGridView.SelectedCells[0].RowIndex);
                        ActualizarGrid();
                        ActualizarMonto();
                    }

                }
                else
                {
                    errorProvider.SetError(DetalledataGridView, "Debe haber productos en la lista para eliminar");
                }
            }
            catch (Exception) { }
        }

        private void DetalledataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DetalledataGridView.SelectedCells.Count > 0)
            {
                EliminarFilametroButton.Enabled = true;
            }
        }


    }
}
