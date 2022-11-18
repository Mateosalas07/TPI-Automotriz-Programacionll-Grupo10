using AutomotrizApp.dominio;
using AutomotrizFront.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront
{
    public partial class frmModificarFactura : Form
    {
        private Factura factura;
        public frmModificarFactura(int nro)
        {
            InitializeComponent();
            factura = new Factura();
            factura.nro_factura = nro;
            //servicio = fabrica.CrearServicio();
            //CargarProductos();
            //CargarFactura(nro);
        }

        private void frmModificarFactura_Load(object sender, EventArgs e)
        {
            //CargarFactura();
            
        }

        //private async void CargarFactura(int nro)
        //{
        //    string url = "https://localhost:5001/ConsultarFactura?id=" + nro;
        //    var result = await ClientSingleton.GetInstance().GetAsync(url);
        //    //DataSet lst = JsonConvert.DeserializeObject<DataSet>(result);
        //    List<Factura> lst = JsonConvert.DeserializeObject<Factura>(result);
        //    //DataTable lst = (DataTable)JsonConvert.DeserializeObject(result, (typeof(DataTable)));

        //    //En el título de la ventana agregamos el número de presupuesto
        //    this.Text = this.Text + factura.nro_factura.ToString();
        //    //string sp = "SP_CONSULTAR_DETALLES_PRESUPUESTO";
        //    //List<Parametro> lst = new List<Parametro>();
        //    //lst.Add(new Parametro("@presupuesto_nro", oPresupuesto.PresupuestoNro));

        //    //DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL(sp, lst);
        //    bool primero = true;

        //    //Mappeamos los datos del presupuesto obtenidos desde el SP
        //    //con un objeto Presupuesto y actualizamos la pantalla:
        //    foreach (Factura factura in lst)
        //    {
        //        //Solo para la primer fila recuperamos los datos del maestro:
        //        if (primero)
        //        {
        //            factura.Cliente = fila["cliente"].ToString();
        //            factura.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
        //            factura.Total = Double.Parse(fila["total"].ToString());
        //            txtCliente.Text = factura.Cliente;
        //            txtFecha.Text = factura.Fecha.ToString();
        //            txtTotal.Text = factura.Total.ToString();
        //            primero = false;
        //        }
        //        int nroVehiculo = int.Parse(fila["id_vehiculo"].ToString());
        //        int nroAutoparte = int.Parse(fila["id_autoparte"].ToString());
        //        string nombre = fila["Nombre"].ToString();
        //        double precio = double.Parse(fila["precio"].ToString());
        //        string color = fila["color"].ToString();
        //        string tipo = fila["Tipo"].ToString();
        //        Vehiculo vehiculo = null;
        //        AutoParte autoparte = null;
        //        int cantidad = int.Parse(fila["cantidad"].ToString());
        //        if (nroVehiculo != null)
        //        {
        //            vehiculo = new Vehiculo(nroVehiculo, precio, color, nombre, tipo);
        //            DetalleFactura detalles = new DetalleFactura(vehiculo, null, cantidad);
        //            factura.AgregarDetalle(detalles);
        //            dgvDetalles.Rows.Add(new object[] { vehiculo.NroVehiculo, vehiculo.Modelo, vehiculo.Precio, cantidad });
        //            txtSubtotal.Text = detalles.CalcularSubTotal(precio).ToString();
        //        }
        //        else
        //        {
        //            autoparte = new AutoParte(nroAutoparte, precio, color, nombre, tipo);
        //            DetalleFactura detalles = new DetalleFactura(null, autoparte, cantidad);
        //            factura.AgregarDetalle(detalles);
        //            dgvDetalles.Rows.Add(new object[] { autoparte.AutoParteNro, autoparte.Nombre, autoparte.Precio, cantidad });
        //            txtSubtotal.Text = detalles.CalcularSubTotal(precio).ToString();
        //        }

                
                
        //    }

        //   // txtTotal.Text = Factura.CalcularTotal().ToString();
        // //   txtFinal.Text = fac.CalcularTotalConDescuento().ToString();
        //}
    }
}
