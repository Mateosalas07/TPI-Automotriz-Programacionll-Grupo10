using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizApp.formularios;

namespace AutomotrizFront
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            habilitar(false);
            //button11.Visible = false;
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.Visible = false;
            habilitar(true);
        }
        public void habilitar(bool x)
        {
            panel1.Visible = x;
            btnConsultas.Visible = x;
            btnSoporte.Visible = x;
            btnProgramacion.Visible = x;
            btnLaboratorio.Visible = x;
            btnAyuda.Visible = x;
            btnVolver.Visible = x;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            habilitar(false);
            btnMenu.Visible = true;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsulta ofrmConsulta = new frmConsulta();
            ofrmConsulta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //mensaje que le pregunta al usuario si desea salir
            if (MessageBox.Show("Seguro de Salir de la aplicación ?",
            "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void btnProgramacion_Click(object sender, EventArgs e)
        {
            frmMenuProgramacion ofrmMenuProgramacion = new frmMenuProgramacion();
            ofrmMenuProgramacion.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmPagDesarrollo odesarrollo = new frmPagDesarrollo();
            odesarrollo.ShowDialog();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            frmPagDesarrollo odesarrollo = new frmPagDesarrollo();
            odesarrollo.ShowDialog();
        }
    }
}
