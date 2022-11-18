using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Dominio
{
    public class FormadePago
    {
        public int Id_forma { get; set; }
        public string Forma_pago { get; set; }
        public FormadePago(int id_forma, string forma_pago)
        {
            Id_forma = id_forma;
            Forma_pago = forma_pago;
        }


    }
}
