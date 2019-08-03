using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public String Nombre { get; set; }
        public String Clave { get; set; }
        public DateTime Fecha { get; set; }
        public String NivelUsuario { get; set; }

        public Usuarios(int usuarioId, string nombre, string clave, DateTime fecha, string nivelUsuario)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Clave = clave;
            Fecha = fecha;
            NivelUsuario = nivelUsuario;
        }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = String.Empty;
            Clave = String.Empty;
            Fecha = DateTime.Now;
            NivelUsuario = String.Empty;
        }
    }
}
