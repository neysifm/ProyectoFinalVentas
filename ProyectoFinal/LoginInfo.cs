using Entidades;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class LoginInfo
    {
        public static Usuarios usuario = null;
        private static LoginForm loginForm = null;
        public static void DenegarPermiso()
        {
            MessageBox.Show($"{usuario.Nombre}, Usted es un usuario de tipo {usuario.NivelUsuario}. No puede efectuar esta operacion.");
        }

        public static LoginForm GetLoginForm()
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
            }
            return loginForm;
        }

        public static bool ValidarAdministrador()
        {
            if (usuario == null || usuario.NivelUsuario != "Administrador")
            {
                DenegarPermiso();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
