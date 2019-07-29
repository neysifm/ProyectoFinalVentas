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
    public partial class RegistroClientes : MetroFramework.Forms.MetroForm, IFormularioRegistros<Clientes>
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            IDnumericUpDown.Value = 0;
            NombremetroTextBox.Clear();
            DireccionmetroTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            EmailmetroTextBox.Clear();
            FechametroDateTime.Value = DateTime.Now;
        }

        public void LlenaCampos(Clientes clientes)
        {
            IDnumericUpDown.Value = clientes.ClienteId;
            NombremetroTextBox.Text = clientes.Nombres;
            DireccionmetroTextBox.Text = clientes.Direccion;
            TelefonomaskedTextBox.Text = clientes.Telefono;
            EmailmetroTextBox.Text = clientes.Email;
            FechametroDateTime.Value = clientes.Fecha;
        }

        public Clientes LlenaClase()
        {
            Clientes clientes = new Clientes()
            {
                ClienteId = Convert.ToInt32(IDnumericUpDown.Value),
                Nombres = NombremetroTextBox.Text,
                Direccion = DireccionmetroTextBox.Text,
                Telefono = TelefonomaskedTextBox.Text,
                Email = EmailmetroTextBox.Text,
                Fecha = FechametroDateTime.Value
            };
            return clientes;
        }

        public bool ValidarBuscar()
        {
            if (IDnumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Clientes>().Buscar(Convert.ToInt32(IDnumericUpDown.Value)) == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarCampos()
        {
            bool validar = true;

            if (string.IsNullOrEmpty(NombremetroTextBox.Text))
            {
                errorProvider.SetError(NombremetroTextBox, "El nombre no puede estar vacio, Llenar Nombre");
                validar = false;
            }
            if (string.IsNullOrEmpty(DireccionmetroTextBox.Text))
            {
                errorProvider.SetError(DireccionmetroTextBox, "La Direccion no puede estar vacia, Llenar Direccion");
                validar = false;
            }
            if (string.IsNullOrEmpty(TelefonomaskedTextBox.Text))
            {
                errorProvider.SetError(TelefonomaskedTextBox, "El Telefono no puede estar vacia, Llenar Telefono");
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

        private void BuscarClientemetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarBuscar())
            {
                Clientes clientes = new RepositorioBase<Clientes>().Buscar(Convert.ToInt32(IDnumericUpDown.Value));
                LlenaCampos(clientes);
            }
            else
            {
                MessageBox.Show("No se encontro el Cliente", "Debe Registrarse!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            _ = new Clientes();
            Clientes clientes = LlenaClase();
            RepositorioBase<Clientes> contexto = new RepositorioBase<Clientes>();
            try
            {
                if (IDnumericUpDown.Value == 0)
                {
                    if (contexto.Guardar(clientes))
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
                    if (contexto.Modificar(clientes))
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
    }
}
