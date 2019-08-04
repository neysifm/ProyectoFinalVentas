using System;
using System.ComponentModel.DataAnnotations;

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
    }
}
