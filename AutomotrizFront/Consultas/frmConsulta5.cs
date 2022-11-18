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
    public partial class frmConsulta5 : Form
    {
        public frmConsulta5()
        {
            InitializeComponent();
        }

        private void frmConsulta5_Load(object sender, EventArgs e)
        {
            CargarConsulta5();
        }

        private void CargarConsulta5()
        {
            // esto agregarlo al siguiente formulario
            string sp = "SP_5TACONSULTA";
            List<Parametro> lst = new List<Parametro>();

            dataGridView1.Rows.Clear();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] {
                    fila["cantidad de vehiculos"].ToString(),
                    fila["tipo_vehiculo"].ToString(),
                   int.Parse(fila["precio total"].ToString())});


            }
        }
    }
}
