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
    public partial class FrmConsulta4 : Form
    {
        public FrmConsulta4()
        {
            InitializeComponent();
        }

        private void FrmConsulta4_Load(object sender, EventArgs e)
        {
            CargarConsulta4();
        }

        private void CargarConsulta4()
        {
            // esto agregarlo al siguiente formulario
            string sp = "SP_4TACONSULTA";
            List<Parametro> lst = new List<Parametro>();

            dataGridView1.Rows.Clear();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] {
                    fila["tipo_vehiculo"].ToString(),
                    fila["modelo"].ToString(),
                    int.Parse(fila["Precio mas caro"].ToString()),
                    int.Parse(fila["Precio mas barato"].ToString())});


            }
        }
    }
}
