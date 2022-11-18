using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Dominio
{
    public class Clientes
    {
        public int cod_cliente { get; set; }
        //public TipoClientes Tipo { get; set; }
        public string Nombre { get; set; }

        public Clientes()
        {

        }
        public Clientes(int id, string nombre /*, TipoClientes tipo*/)
        {
            cod_cliente = id;
            Nombre = nombre;
        //    Tipo = tipo;
        }
    }

    
}
