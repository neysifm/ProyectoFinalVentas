using System;
using System.Collections.Generic;
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
        public String NivelUsuario { get; set; }

        public Usuarios(int usuarioId, string nombre, string clave, string nivelUsuario)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Clave = clave;
            NivelUsuario = nivelUsuario;
        }
        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = String.Empty;
            Clave = String.Empty;
            NivelUsuario = String.Empty;
        }
    }
}
