using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public String Descripcion { get; set; }

        public Categorias(int categoriaId, string descripcion)
        {
            CategoriaId = categoriaId;
            Descripcion = descripcion;
        }
    }
}
