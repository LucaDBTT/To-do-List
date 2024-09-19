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
        private string id_usuario {  get; set; }
        private string NombreUsuario {  get; set; }
        private string Password { get; set; }
        public TipoUsuarios TipoUsuario { get; set; }
        private bool Estado { get; set; }

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
