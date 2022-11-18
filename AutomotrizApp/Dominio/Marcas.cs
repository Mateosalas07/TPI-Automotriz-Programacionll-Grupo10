using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Dominio
{
    class Marcas
    {
        public int Id_marca { get; set; }
        public string Marca { get; set; }

        public Marcas(int id,string marca)
        {
            Id_marca = id;
            Marca = marca;
        }

        public Marcas()
        {

        }
    }
}
