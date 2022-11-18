using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.dominio
{
   public class AutoParte
    {
        public int AutoParteNro { get; set; }
        public double Precio { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public bool Activo { get; set; }
        public string Tipo { get; set; }
        public AutoParte(int AutoPnro, double pre,string nombre, string color,string tipo)
        {
            AutoParteNro = AutoPnro;
            Precio = pre;
           Nombre = nombre;
            Color = color;
            Activo = true;
            Tipo = tipo;
        }
        public AutoParte()
        {

        }
    }
}
