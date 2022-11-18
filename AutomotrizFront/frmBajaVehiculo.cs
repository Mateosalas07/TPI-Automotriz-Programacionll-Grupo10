using AutomotrizApp.Datos;
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
    public partial class frmBajaVehiculo : Form
    {
        
        public frmBajaVehiculo()
        {
            InitializeComponent();

        }

        private void frmBajaVehiculo_Load(object sender, EventArgs e)
        {
            CargarVehiculosAsync();
        }

        private async void CargarVehiculosAsync()
        {
            string url = "https://localhost:5001/Vehiculos";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<DataTable>(result);
            List<Parametro> list = new List<Parametro>();
            list.Add(new Parametro("@Activo", colActivo.ValueType ));
            foreach (DataRow fila in lst.Rows)
            {
                dgsTabla.Rows.Add(new object[] {
                    fila["NroVehiculo"].ToString(),                    
                    fila["Modelo"].ToString(),
                    fila["Tipo"].ToString(),
                    int.Parse(fila["Precio"].ToString()),
                    fila["Color"].ToString(),
                    fila["Activo"].ToString()});


            }

        }

        private void dgsTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgsTabla.CurrentCell.ColumnIndex == 6)
            //{
            //    int id = int.Parse(dgsTabla.CurrentCell.["colID"].Value.ToString());

            //}
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCodigo.Text);
            DarBajaAsync(id);
        }

        private async Task DarBajaAsync(int id)
        {
            //string bodyContent = JsonConvert.SerializeObject(id);

            string url = "https://localhost:5001/api/Vehiculo/eliminarVehiculo?id=" + id;
            var result = await ClientSingleton.GetInstance().DeleteAsync(url);

            if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)
            {
                MessageBox.Show("Vehículo dado de Baja", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarVehiculosAsync();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo actualizar los datos del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
