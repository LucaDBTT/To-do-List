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
        private int id_persona {get; set;}
        private string Nombre { get; set;}
        private string Apellido {  get; set;}
        private string Dni { get; set;}
        private DateTime FechaNacimiento {  get; set;}
        private string Nacionalidad { get; set;}
        public string Direccion { get; set; }


        public override string ToString()
        {
            return Nombre + " " + Apellido + 
            ", DNI: " + Dni + ", NACIMIENTO: "+ FechaNacimiento + ", NACIONALIDAD: " + Nacionalidad + ", " +
            "DIRECCION: " + Direccion;
        }

    }
}
