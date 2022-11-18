using AutomotrizApp.Datos;
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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            cargarConsultas();
        }

        private void cargarConsultas()
        {
            
        }

        private void cboConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboConsultas.Text.Equals("Consulta 1"))
            {
                //txtDescripcion.Text = "Listar los datos de los Vehículos que aún no fueron vendidos y sean de color ingresado.";
                lblDescripcion.Text = "Está consulta lista los datos de los Vehículos que aún no fueron vendidos y sean del color que se ingresa por teclado.";
            }
            else if (cboConsultas.Text.Equals("Consulta 2")) { 
                //txtDescripcion.Text = "Listar el año, mes y cliente que hicieron compras entre las fechas ingresadas.";
                lblDescripcion.Text = "Está consulta lista el año, mes y los clientes que hicieron compras entre las fechas ingresadas por teclado.";
            }

            else if (cboConsultas.Text.Equals("Consulta 3"))
                lblDescripcion.Text = "Está consulta emite un listado de los Clientes que compraron Autopartes y la cantidad comprada oscile entre la cantidad de piezas ingresadas por teclado.";

            else if (cboConsultas.Text.Equals("Consulta 4"))
                lblDescripcion.Text = "Está consulta muestra los vehículos disponibles con su tipo y modelo y, además, mostrara el precio mínimo y máximo de venta que tuvieron este año.";

            else if (cboConsultas.Text.Equals("Consulta 5"))
                lblDescripcion.Text = "Está consulta trae la cantidad de vehículos con el precio total de venta de cada Tipo de Vehiculos, siempre y cuando el precio por vehiculo sea menor o igual a $2.000.000";

            else if (cboConsultas.Text.Equals("Consulta 6"))
                lblDescripcion.Text = "Está consulta muestra los Vehículos con su modelo y precio de venta, cuyo precio se encuentre entre los montos ingresados por teclado.";

            else if (cboConsultas.Text.Equals("Consulta 7"))
                lblDescripcion.Text = "Está consulta emite un listado de los clientes con nombre que empiecen en 'M' y hayan comprado vehiculos este año; ademas mostrar que tipo de cliente era el mismo y en que fecha adquirió el vehículo.";

            else if (cboConsultas.Text.Equals("Consulta 8"))
                lblDescripcion.Text = "Está consulta muestra la cantidad total de autopartes que compraron los clientes, Se debe ingresar cantidad minima requerida por teclado para filtrar la consulta.. ";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(cboConsultas.Text.Equals("Consulta 1"))
            {
                frmConsulta1 ofrmconsulta1 = new frmConsulta1();
                ofrmconsulta1.ShowDialog();
            }
            else if(cboConsultas.Text.Equals("Consulta 2"))
            {
                frmConsulta2 ofrmconsulta2 = new frmConsulta2();
                ofrmconsulta2.ShowDialog();
            }
            else if (cboConsultas.Text.Equals("Consulta 3"))
            {
                frmConsulta3 ofrmConsulta3 = new frmConsulta3();
                ofrmConsulta3.ShowDialog();
            }
            else if (cboConsultas.Text.Equals("Consulta 4"))
            {
                FrmConsulta4 ofrmConsulta4 = new FrmConsulta4();
                ofrmConsulta4.ShowDialog();
            }
            else if (cboConsultas.Text.Equals("Consulta 5"))
            {
                frmConsulta5 ofrmConsulta5 = new frmConsulta5();
                ofrmConsulta5.ShowDialog();
            }
            else if (cboConsultas.Text.Equals("Consulta 6"))
            {
                frmConsulta6 ofrmConsulta6 = new frmConsulta6();
                ofrmConsulta6.ShowDialog();
            }
            else if (cboConsultas.Text.Equals("Consulta 7"))
            {
                frmConsulta7 ofrmConsulta7 = new frmConsulta7();
                ofrmConsulta7.ShowDialog();
            }
            else if (cboConsultas.Text.Equals("Consulta 8"))
            {
                frmConsulta8 ofrmConsulta8 = new frmConsulta8();
                ofrmConsulta8.ShowDialog();
            }
            



        }

        private void frmConsulta_Load_1(object sender, EventArgs e)
        {

        }
    }
}
