using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Dominio
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }
        public Usuario()
        {

        }
    }
}
