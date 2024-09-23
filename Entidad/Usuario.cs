using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario : Persona
    {
        public enum TipoUsuarios
        {
            administrador = 1,
            vendedor = 2
        }
        public string id_usuario {  get; set; }
        public string NombreUsuario {  get; set; }
        public string Password { get; set; }
        public TipoUsuarios TipoUsuario { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return base.ToString() + "USUARIO: " + NombreUsuario;
        }


        public Usuario(string user, string pass, bool esAdmin, bool esVendedor)
        {
            NombreUsuario = user;
            Password = pass;
            TipoUsuario = esAdmin ? TipoUsuarios.administrador : TipoUsuarios.vendedor;
        }
    }
}
