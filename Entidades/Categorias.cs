using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public String Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public Categorias(int categoriaId, string descripcion, DateTime fecha)
        {
            CategoriaId = categoriaId;
            Descripcion = descripcion;
            Fecha = fecha;
        }

        public Categorias()
        {
            CategoriaId = 0;
            Descripcion = String.Empty;
            Fecha = DateTime.Now;
        }
    }
}
