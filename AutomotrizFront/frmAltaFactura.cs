using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizApp.dominio;
using AutomotrizApp.Dominio;
using AutomotrizApp.Fachada;
using AutomotrizFront.Http;
using Newtonsoft.Json;


namespace AutomotrizFront
{
    public partial class frmAltaFactura : Form
    {
        private Factura nuevo;
        private IDataApi dataApi;
        public frmAltaFactura()
        {
            InitializeComponent();
            dataApi = new DataApiImp();
            nuevo = new Factura();
            
        }

        private void  frmAltaFactura_Load(object sender, EventArgs e)
        {
            ProximaFactura();
            DateTime fecha = DateTime.Now;
            txtFecha.Text = fecha.ToShortDateString();
            //CargarClientesAsync();

            //CargarFormadePagoAsync();



        }

        private async void CargarFormadePagoAsync()
        {
            string url = "https://localhost:5001/FormaPago";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clientes>>(result);
            cboFormaPago.DataSource = lst;
            cboFormaPago.ValueMember = "id_forma";
            cboFormaPago.DisplayMember = "forma_pago";
        }

        private async void CargarTiposClientesAsync()
        {
            string url = "https://localhost:5001/TiposCliente";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Vehiculo>>(result);
            //cboTipoCliente.DataSource = lst;
            //cboTipoCliente.DisplayMember = "Tipo";
            //cboTipoCliente.ValueMember = "id_tipo";
        }

        private async void ProximaFactura()
        {
            string url = "https://localhost:5001/ProximoID";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            string next = JsonConvert.DeserializeObject<string>(result); 
            //if (next =='0')
                lblFactura.Text = "Factura Nº:" + next;
            //else
            //    MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task CargarArticulos(string tabla)
        {
            lblSeleccion.Text = "Modelos Disponibles:";
            if (tabla == "Vehiculos")
            {
                
               await CargarVehiculosAsync();
                

            }
            else
            {
               await CargarAutopartesAsync();
                
            }
            


        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarArticulos(cboItem.Text.ToString());
        }

        private void cboItem_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CargarClientesAsync();
        }

        private async void CargarClientesAsync()
        {
            string url = "https://localhost:5001/Clientes";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Clientes>>(result);
            cboClientes.DataSource = lst;
            cboClientes.ValueMember = "cod_cliente";
            cboClientes.DisplayMember = "Nombre";
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboArticulos.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un Articulo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCantidad.Text == "" || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colArt"].Value.ToString().Equals(cboArticulos.Text))
                {
                    MessageBox.Show("Articulo: " + cboArticulos.Text + " ya se encuentra dentro de la Factura!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }
            if (cboItem.Text.Equals("Vehiculos"))
            {
                Vehiculo v = (Vehiculo)cboArticulos.SelectedItem;
                double precio = v.Precio;
                int cantidad = Convert.ToInt32(txtCantidad.Text);

               // DetalleFactura detalle = new DetalleFactura(v, null, cantidad);
                //nuevo.AgregarDetalle(detalle);
                dgvDetalles.Rows.Add(new object[] { v.NroVehiculo, v.Modelo, v.Precio, txtCantidad.Text });
                //txtSubtotal.Text = detalle.CalcularSubTotal(precio).ToString();
            }
            else
            {
                AutoParte autopartes = (AutoParte)cboArticulos.SelectedItem;
                double precio = autopartes.Precio;
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                DetalleFactura detalle = new DetalleFactura(/*null,*/autopartes, cantidad);
                nuevo.AgregarDetalle(detalle);
                dgvDetalles.Rows.Add(new object[] { autopartes.AutoParteNro, autopartes.Nombre, autopartes.Precio, txtCantidad.Text });
                txtSubtotal.Text = detalle.CalcularSubTotal(precio).ToString();
            }

                
            //int cantidad = Convert.ToInt32(txtCantidad.Text);

            //DetalleFactura detalle = new DetalleFactura(v,null,cantidad,0);
            //nuevo.AgregarDetalle(detalle);
            //dgvDetalles.Rows.Add(new object[] { v.VehiculoNro, v.Modelo, v.Precio, txtCantidad.Text });

            txtTotal.Text= nuevo.CalcularTotal().ToString();
        }


        private void CalcularTotal()
        {
            double total = nuevo.CalcularTotal();
            txtTotal.Text = total.ToString();
            
            
        }

        private void lblFactura_Click(object sender, EventArgs e)
        {

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Debe seleccionar un cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboFormaPago.Text == "")
            {
                MessageBox.Show("Debe seleccionar una Forma de pago!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            await GuardarFacturaAsync();
        }

        private async Task GuardarFacturaAsync()
        {
            //datos de la Factura:
            nuevo.Cliente = txtCliente.Text;
            nuevo.Forma_pago = cboFormaPago.Text;// se debe agregar un +1 en la base debido a que index arranca de 0;
            //nuevo.Fecha =txtFecha.Text.ToString('dd/mm/yyyy');
           
            nuevo.Total = Convert.ToDouble(txtTotal.Text);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:5001/Factura/GuardarFactura";
            //string resultado = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);
            bool resultado = dataApi.SaveFactura(nuevo);
            if (resultado)
            {
                MessageBox.Show("Factura registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private async Task CargarVehiculosAsync()
        {
            string url = "https://localhost:5001/Vehiculos";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Vehiculo>>(result);
            cboArticulos.DataSource = lst;
            cboArticulos.DisplayMember = "Modelo";
            cboArticulos.ValueMember = "NroVehiculo";
        }

        private async Task CargarAutopartesAsync()
        {
            string url = "https://localhost:5001/Autopartes";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<AutoParte>>(result);
            cboArticulos.DataSource = lst;
            cboArticulos.DisplayMember = "Nombre";
            cboArticulos.ValueMember = "AutoParteNro";
        }

    }
}
