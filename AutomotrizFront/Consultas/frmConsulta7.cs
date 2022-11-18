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
    public partial class frmConsulta7 : Form
    {
        public frmConsulta7()
        {
            InitializeComponent();
        }

        private void frmConsulta7_Load(object sender, EventArgs e)
        {
            CargarConsulta7();
        }

        private void CargarConsulta7()
        {

            // esto agregarlo al siguiente formulario
            string sp = "SP_7MACONSULTA";
            List<Parametro> lst = new List<Parametro>();

            dataGridView1.Rows.Clear();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, null);
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] {
                    fila["Cliente"].ToString(),
                    fila["Tipo de Cliente"].ToString(),
                    fila["Fecha"].ToString()});


            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
