using AutomotrizFront;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp.formularios
{
    public partial class frmMenuProgramacion : Form
    {
        public frmMenuProgramacion()
        {
            InitializeComponent();
            Habilitarpanel(false);
        }

        private void Habilitarpanel(bool x)
        {
            pFacturas.Visible = x;
            pReportes.Visible = x;
            pSoporte.Visible = x;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Habilitarpanel(false);
            pFacturas.Visible = true;
            //btnFacturas.Click += pFacturas.Visible(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Habilitarpanel(false);
            pReportes.Visible = true;
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            Habilitarpanel(false);
            pSoporte.Visible = true;
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            frmAltaFactura ofrmAltaFactura = new frmAltaFactura();
            ofrmAltaFactura.ShowDialog();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            frmAltaVehiculo ofrmAltaVehiculo = new frmAltaVehiculo();
            ofrmAltaVehiculo.ShowDialog();
        }

        

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            frmModificarVehiculo frmModificarVehiculo = new frmModificarVehiculo();
            frmModificarVehiculo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBajaVehiculo frmBajaVehiculo = new frmBajaVehiculo();
            frmBajaVehiculo.ShowDialog();
        }

        private void btnConsultarFactura_Click(object sender, EventArgs e)
        {
            frmConsultaFactura frmConsultaFactura = new frmConsultaFactura();
            frmConsultaFactura.ShowDialog();
        }
    }
}
