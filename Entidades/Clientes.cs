using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Decimal Balance { get; set; }

        public Clientes(int clienteId, string nombres, string direccion, string telefono, string email, DateTime fecha, decimal balance)
        {
            ClienteId = clienteId;
            Nombres = nombres;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Fecha = fecha;
            Balance = balance;
        }

        public Clientes()
        {
            ClienteId = 0;
            Nombres = String.Empty;
            Direccion = String.Empty;
            Telefono = String.Empty;
            Email = String.Empty;
            Fecha = DateTime.Now;
            Balance = 0;
        }
    }
}
