using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Tarea
    {
        private int Id_tarea { get; set; }
        private Usuario Usuario { get; set; }
        private string Descripcion { get; set; }
        private DateTime FechaCreacion { get; set; }
        private DateTime FechaVencimiento { get; set; }
        private bool EstaCompletada { get; set; }
        private string Prioridad { get; set; } // Alta, Media, Baja
        private Tag Etiqueta { get; set; } 
        private Categoria Categoria { get; set; }
        private Reminder Reminder { get; set; }

    }
}
