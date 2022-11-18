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
    public partial class frmAltaVehiculo : Form
    {
        private Vehiculo nuevo;
        public frmAltaVehiculo()
        {
            InitializeComponent();
            nuevo = new Vehiculo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                MessageBox.Show("Debe ingresar un color!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboModelo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un Modelo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPrecio.Text=="")
            {
                MessageBox.Show("Debe ingresar un precio!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboTipoVehiculo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una Tuipo de Vehiculo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            await GuardarVehiculoAsync();



        }
        private async Task GuardarVehiculoAsync()
        {
            //datos del presupuesto:
            nuevo.Color = txtColor.Text.ToString();
            nuevo.Precio = Convert.ToDouble(txtPrecio.Text);
            nuevo.Modelo = Convert.ToString(cboModelo.Text);
            nuevo.Tipo = Convert.ToString(cboTipoVehiculo.Text);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:5001/CrearVehiculo";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)
            {
                MessageBox.Show("Vehiculo registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAltaVehiculo_Load(object sender, EventArgs e)
        {

        }
        private async void ProximoVehiculo()
        {
            string url = "https://localhost:5001/ProximoID";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            string next = JsonConvert.DeserializeObject<string>(result);
            //if (next =='0')
            lblNroVechiculo.Text =  next;
            //else
            //    MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
