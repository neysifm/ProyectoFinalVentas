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
    public partial class RegistroUsuarios : MetroFramework.Forms.MetroForm, IFormularioRegistros<Usuarios>
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            IDnumericUpDown.Value = 0;
            NombremetroTextBox.Clear();
            ClavemetroTextBox.Clear();
            ConfirmarClavemetroTextBox.Clear();
            FechametroDateTime.Value = DateTime.Now;
            UsuarioNormalradioButton.Checked = false;
            UsuarioAdministradorradioButton.Checked = false;
        }

        public void LlenaCampos(Usuarios usuarios)
        {
            IDnumericUpDown.Value = usuarios.UsuarioId;
            NombremetroTextBox.Text = usuarios.Nombre;
            ClavemetroTextBox.Text = usuarios.Clave;
            ConfirmarClavemetroTextBox.Text = usuarios.ConfirmarClave;
            FechametroDateTime.Value = usuarios.Fecha;
            //FALTAN LOS RADIO BUTTON
        }

        public Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios()
            {
                UsuarioId = Convert.ToInt32(IDnumericUpDown.Value),
                Nombre = NombremetroTextBox.Text,
                Clave = ClavemetroTextBox.Text,
                ConfirmarClave = ConfirmarClavemetroTextBox.Text,
                Fecha = FechametroDateTime.Value,
               // NivelUsuario
            };
            return usuarios;
        }

        public bool ValidarBuscar()
        {
            if (IDnumericUpDown.Value <= 0)
            {
                return false;
            }
            if (new RepositorioBase<Usuarios>().Buscar(Convert.ToInt32(IDnumericUpDown.Value)) == null)
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
            if (string.IsNullOrEmpty(ClavemetroTextBox.Text))
            {
                errorProvider.SetError(ClavemetroTextBox, "La Clave no puede estar vacia, Llenar Clave");
                validar = false;
            }

            //VALIDAR LOS RADIO BUTTON

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
                Usuarios usuarios = new RepositorioBase<Usuarios>().Buscar(Convert.ToInt32(IDnumericUpDown.Value));
                LlenaCampos(usuarios);
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Debe Registrarse!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            _ = new Usuarios();
            Usuarios usuario = LlenaClase();
            RepositorioBase<Usuarios> contexto = new RepositorioBase<Usuarios>();
            try
            {
                if (IDnumericUpDown.Value == 0)
                {
                    if (contexto.Guardar(usuario))
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
                    if (contexto.Modificar(usuario))
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
                new RepositorioBase<Usuarios>().Eliminar(Convert.ToInt32(IDnumericUpDown.Value));
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
