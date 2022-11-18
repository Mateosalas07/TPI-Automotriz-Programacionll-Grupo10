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
    public partial class frmConsulta6 : Form
    {
        public frmConsulta6()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sp = "SP_6TACONSULTA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@precio1", txtDesde.Text.ToString()));
            lst.Add(new Parametro("@precio2", txtHasta.Text.ToString()));

            dataGridView1.Rows.Clear();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, lst);
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] {
                    fila["Modelo"].ToString(),
                    int.Parse(fila["Precio de Venta"].ToString())});


            }
        }
    }
}
