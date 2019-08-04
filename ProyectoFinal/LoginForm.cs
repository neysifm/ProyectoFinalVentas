using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string clave = txtClave.Text;
            List<Usuarios> lista = new RepositorioBase<Usuarios>().GetList(x => x.Nombre.Equals(usuario) && x.Clave.Equals(clave));
            bool paso = lista.Count > 0;

            if (paso)
            {
                Usuarios user = lista[0];
                LoginInfo.usuario = user;
                MainForm frm = new MainForm();

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "Usuario o Contraseña Incorreta, Intentelo de nuevo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool VerificarClick()
        {
            if (txtuser.Text.Length > 0 && txtClave.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void Txtuser_TextChanged(object sender, EventArgs e)
        {
            if (VerificarClick())
            {
                this.btnlogin.Enabled = true;
                this.btnlogin.BackColor = Color.RoyalBlue;
            }
            else
            {
                this.btnlogin.Enabled = false;
                this.btnlogin.BackColor = Color.Gray;
            }
        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {
            if (VerificarClick())
            {
                this.btnlogin.Enabled = true;
                this.btnlogin.BackColor = Color.RoyalBlue;
            }
            else
            {
                this.btnlogin.Enabled = false;
                this.btnlogin.BackColor = Color.Gray;
            }
        }
    }
}
