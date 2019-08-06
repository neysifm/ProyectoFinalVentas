using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public String Nombre { get; set; }
        public String Clave { get; set; }
        public String ConfirmarClave { get; set; }
        public DateTime Fecha { get; set; }
        public String NivelUsuario { get; set; }

        public Usuarios(int usuarioId, string nombre, string clave, string confirmarClave, DateTime fecha, string nivelUsuario)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Clave = clave;
            ConfirmarClave = confirmarClave;
            Fecha = fecha;
            NivelUsuario = nivelUsuario;
        }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = String.Empty;
            Clave = String.Empty;
            ConfirmarClave = String.Empty;
            Fecha = DateTime.Now;
            NivelUsuario = String.Empty;
        }

        public static string Encriptar(string cadenaEncriptada)
        {
            string resultado = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(cadenaEncriptada);
            resultado = Convert.ToBase64String(encryted);

            return resultado;
        }

        public static string DesEncriptar(string cadenaDesencriptada)
        {
            string resultado = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaDesencriptada);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);

            return resultado;
        }
    }
}
