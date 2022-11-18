using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizApp.dominio;
using System.Data;
using AutomotrizApp.Dominio;

namespace AutomotrizApp.Datos.Intefaz
{
    interface IDaoFactura
    {
        List<Vehiculo> ObtenerVehiculos();
        List<AutoParte> ObtenerAutopartes();
        int ObtenerProximoNro();
        bool Crear(Factura oFactura);
        bool ActualizarVehiculo(Vehiculo vehiculo);
        bool BorrarVehiculo(int nro);
        List<Factura> ObtenerFacturaPorFiltros(DateTime desde, DateTime hasta, string cliente);
        Factura ObtenerFacturaPorNro(int nro);
        DataTable ObtenerReporte(DateTime desde, DateTime hasta);
        bool ConsultarUsuario(Usuario usuario);

        //bool Consulta1(Usuario usuario);
        List<TipoClientes> ConsultarTipoClientes();

        List<Clientes> ConsultarClientes();

        List<FormadePago> ObtenerFormadePago();

        public bool CrearVehiculo(Vehiculo vehiculo);

        bool DarBajaFactura(int nro);
    }

}
