using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Tarea
    {
        public int Id_tarea { get; set; }
        public Usuario Usuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool EstaCompletada { get; set; }
        public string Prioridad { get; set; } // Alta, Media, Baja
        public Tag Etiqueta { get; set; } 
        public Categoria Categoria { get; set; }
        public Reminder Reminder { get; set; }

    }
}
