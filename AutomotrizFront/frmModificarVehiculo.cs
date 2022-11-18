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
    public partial class frmModificarVehiculo : Form
    {
        Vehiculo modificar;
        public frmModificarVehiculo()
        {
            InitializeComponent();
            modificar = new Vehiculo();
            
        }

        private void frmModificarVehiculo_Load(object sender, EventArgs e)
        {
            CargarVehiculosAsync();
        }


        public async void CargarVehiculosAsync()
        {
            string url = "https://localhost:5001/Vehiculos";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Vehiculo>>(result);
            cboVehiculo.DataSource = lst;
            cboVehiculo.DisplayMember = "Modelo";
            cboVehiculo.ValueMember = "NroVehiculo";
        }

        private void cboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumero.Text = (cboVehiculo.SelectedIndex +1).ToString();
            cboModelo.DataSource = cboVehiculo.DataSource;
            cboModelo.ValueMember = "NroVehiculo";
            cboModelo.DisplayMember = "Modelo";
            cboModelo.Enabled = false;

            cboTipoVehiculo.DataSource = cboVehiculo.DataSource;
            cboTipoVehiculo.ValueMember = "NroVehiculo";
            cboTipoVehiculo.DisplayMember = "Tipo";
            cboTipoVehiculo.Enabled = false;
            //DataRowView item = (DataRowView)cboVehiculo.SelectedItem;
            //txtPrecio.Text = cboVehiculo.SelectedItem[0];
            //txtColor.Text = item.Row[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
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
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboTipoVehiculo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una Tuipo de Vehiculo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ModificarVehiculoAsync();
        }

        private async void ModificarVehiculoAsync()
        {
            modificar.Modelo = cboModelo.Text.ToString();
            modificar.Tipo = cboTipoVehiculo.Text.ToString();
            modificar.Color = txtColor.Text;
            modificar.Precio = Convert.ToDouble(txtPrecio.Text);
            modificar.NroVehiculo = Convert.ToInt32(lblNumero.Text);

            string bodyContent = JsonConvert.SerializeObject(modificar);

            string url = "https://localhost:5001/ModificarVehiculo";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)
            {
                MessageBox.Show("Datos del vehículo actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo actualizar los datos del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se perderan los cambios no guardados. Salir de la aplicación ?",
            "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
    }
}
