using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Dominio
{
    public class TipoClientes
    {
        public int id_tipo { get; set; }
        public string Tipo { get; set; }

        public TipoClientes(int id_tipo, string tipo)
        {
            this.id_tipo = id_tipo;
            Tipo = tipo;
        }
        public TipoClientes()
        {

        }
    }
}
