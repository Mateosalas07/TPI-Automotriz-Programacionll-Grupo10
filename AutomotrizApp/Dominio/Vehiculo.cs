using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.dominio
{
    public class Vehiculo
    {
        public int NroVehiculo { get; set; }
        public double Precio { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
        public Vehiculo( int nro,double pre,string color,string modelo, string tipo)
        {
            NroVehiculo = nro;
            Precio = pre;
            Color = color;
            Modelo = modelo;
            Tipo = tipo;
            Activo = true;
        }

        public Vehiculo()
        {

        }
        public override string ToString()
        {
            return Color;
        }

    }
}
