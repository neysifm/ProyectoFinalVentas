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
            throw new NotImplementedException();
        }

        public void LlenaCampos(Categorias obj)
        {
            throw new NotImplementedException();
        }

        public Categorias LlenaClase()
        {
            throw new NotImplementedException();
        }

        public bool ValidarBuscar()
        {
            throw new NotImplementedException();
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
    }
}
