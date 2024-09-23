using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        public int id_persona {get; set;}
        public string Nombre { get; set;}
        public string Apellido {  get; set;}
        public string Dni { get; set;}
        public DateTime FechaNacimiento {  get; set;}
        public string Nacionalidad { get; set;}
        public string Direccion { get; set; }


        public override string ToString()
        {
            return Nombre + " " + Apellido + 
            ", DNI: " + Dni + ", NACIMIENTO: "+ FechaNacimiento + ", NACIONALIDAD: " + Nacionalidad + ", " +
            "DIRECCION: " + Direccion;
        }

    }
}
