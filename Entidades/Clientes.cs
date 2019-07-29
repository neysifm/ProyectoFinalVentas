using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public String Nombres { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public DateTime Fecha { get; set; }

        public Clientes(int clienteId, string nombres, string direccion, string telefono, string email, DateTime fecha)
        {
            ClienteId = clienteId;
            Nombres = nombres;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Fecha = fecha;
        }
    }
}
