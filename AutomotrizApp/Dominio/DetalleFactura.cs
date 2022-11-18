using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.dominio
{
    public class DetalleFactura
    {
        //public Vehiculo Vehiculo { get; set; }
        public AutoParte AutoParte { get; set; }
        public int Cantidad { get; set; }
        public DetalleFactura(/*Vehiculo vehiculo*/AutoParte autoParte, int cant /*double precio*/) {
            //Vehiculo = vehiculo;
            AutoParte = autoParte;
            Cantidad = cant;
        }

        public double CalcularSubTotal(double precio) {
            return precio * Cantidad;
        }

    }
}
