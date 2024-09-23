using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Categoria
    {
        public int Id_cat { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
