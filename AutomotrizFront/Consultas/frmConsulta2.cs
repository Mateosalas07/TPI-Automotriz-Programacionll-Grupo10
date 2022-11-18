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
    public partial class frmConsulta2 : Form
    {
        public frmConsulta2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            // esto agregarlo al siguiente formulario
            string sp = "SP_2DACONSULTA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@mes1", dtpDesde.Value.ToString()));
            lst.Add(new Parametro("@mes2", dtpHasta.Value.ToString()));

            dataGridView1.Rows.Clear();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, lst);
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] {
                    fila["Fecha"].ToString(),
                    fila["Cliente"].ToString(),
                    fila["Tipo Cliente"].ToString()});


            }
        }
    }
}
