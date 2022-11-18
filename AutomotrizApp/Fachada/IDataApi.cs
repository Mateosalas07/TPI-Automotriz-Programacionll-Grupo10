using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizApp.dominio;
using AutomotrizApp.Dominio;

namespace AutomotrizApp.Fachada
{
  public interface IDataApi
    {
        public List<Vehiculo> GetVehiculos();

        public List<AutoParte> GetAutoPartes();
        public bool SaveFactura(Factura factura);
        public bool EditarVehiculo(Vehiculo oVehiculo);
        public bool EliminarVehiculo(int id);
        public int ProximaFactura();
        public List<TipoClientes> GetTipoClientes();
        public List<Clientes> GetClientes();
        public bool PostVehiculo(Vehiculo vehiculo);
        public List<FormadePago> GetForma_Pago();
        public bool PostConsultarUsuario(Usuario usuario);

        public List<Factura> ObtenerFacturaporFiltros(DateTime desde, DateTime hasta, string cliente);
        public Factura ObtenerFacturaPorNro(int nro);
        public bool BajaFactura(int id);
    }
}
