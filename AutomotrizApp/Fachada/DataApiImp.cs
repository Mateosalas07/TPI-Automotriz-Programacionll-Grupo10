using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizApp.dominio;
using AutomotrizApp.Datos.Implementacion;
using AutomotrizApp.Datos.Intefaz;
using AutomotrizApp.Dominio;

namespace AutomotrizApp.Fachada
{
    public class DataApiImp : IDataApi
    {
        private IDaoFactura dao;

        public DataApiImp()
        {
            dao = new FacturaDao();
        }

        public List<Vehiculo> GetVehiculos()
        {
            return dao.ObtenerVehiculos();
        }

        public List<AutoParte> GetAutoPartes()
        {
            return dao.ObtenerAutopartes();
        }

        public bool SaveFactura(Factura factura)
        {
            return dao.Crear(factura);
        }
        public bool EditarVehiculo(Vehiculo oVehiculo)
        {
            return dao.ActualizarVehiculo(oVehiculo);
        }

        public bool EliminarVehiculo(int id)
        {
            return dao.BorrarVehiculo(id);
        }

        public int ProximaFactura()
        {
            return dao.ObtenerProximoNro();
        }

        public List<TipoClientes> GetTipoClientes()
        {
            return dao.ConsultarTipoClientes();
        }

        public List<Clientes> GetClientes(/*int tipo*/)
        {
            return dao.ConsultarClientes(/*int tipo*/);
        }

        public bool PostConsultarUsuario(Usuario usuario)
        {
            return dao.ConsultarUsuario(usuario);
        }

        public List<FormadePago> GetForma_Pago()
        {
            return dao.ObtenerFormadePago();
        }
    
        public bool PostVehiculo(Vehiculo vehiculo)
        {
            return dao.CrearVehiculo(vehiculo);
        }

        public List<Factura> ObtenerFacturaporFiltros(DateTime desde, DateTime hasta, string cliente)
        {
            return dao.ObtenerFacturaPorFiltros(desde, hasta, cliente);
        }

        public Factura ObtenerFacturaPorNro(int nro)
        {
            return dao.ObtenerFacturaPorNro(nro);
        }

        public bool BajaFactura(int id)
        {
            return dao.DarBajaFactura(id);
        }
    }
}
