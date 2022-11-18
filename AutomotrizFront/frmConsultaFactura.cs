using AutomotrizApp.dominio;
using AutomotrizApp.Fachada;
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
    public partial class frmConsultaFactura : Form
    {
        private IDataApi dataApi;
        public frmConsultaFactura()
        {
            dataApi = new DataApiImp();
            InitializeComponent();
        }

        private  void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvFacturas.Rows.Clear();
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string cliente = txtCliente.Text;
            //string url = "https://localhost:5001/GetFacturas";
            //var result = await ClientSingleton.GetInstance().GetAsync(url);
            //List<Factura> lst = JsonConvert.DeserializeObject<List<Factura>>(result);//servicio.ObtenerPresupuestos(dtpDesde.Value, dtpHasta.Value, txtCliente.Text);
            List<Factura> lst = dataApi.ObtenerFacturaporFiltros(dtpDesde.Value, dtpHasta.Value, txtCliente.Text);
            DateTime baja = Convert.ToDateTime("01 / 01 / 0001 0:00:00");
            foreach (Factura factura in lst)
            {
                if(factura.FechaBaja == null)
                {
                    dgvFacturas.Rows.Add(new object[] {
                    factura.nro_factura,
                    factura.Fecha,
                    factura.Cliente,
                    factura.Total,
                    " "
                    });
                }
                else
                {
                    dgvFacturas.Rows.Add(new object[] {
                    factura.nro_factura,
                    factura.Fecha,
                    factura.Cliente,
                    factura.Total,
                    factura.FechaBaja
                    });
                }
                
            }
            btnBorrar.Enabled = BtnEditar.Enabled = true;
        }

        private void frmConsultaFactura_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(7);
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvFacturas.CurrentRow.Cells["colNro"].Value.ToString());
            frmModificarFactura frmModificarFactura = new frmModificarFactura(nro);
            frmModificarFactura.ShowDialog();
            //new frmModificarFactura(nro).ShowDialog();
            this.btnConsultar_Click(null, null);
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvFacturas.CurrentRow.Cells["colNro"].Value.ToString());
            DarBajaAsync(nro);
        }


        private async Task DarBajaAsync(int id)
        {
            //string bodyContent = JsonConvert.SerializeObject(id);

            string url = "https://localhost:5001/api/Factura/BajaFactura?id=" + id;
            var result = await ClientSingleton.GetInstance().DeleteAsync(url);

            if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)
            {
                MessageBox.Show("Vehículo dado de Baja", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //CargarVehiculosAsync();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo actualizar los datos del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
