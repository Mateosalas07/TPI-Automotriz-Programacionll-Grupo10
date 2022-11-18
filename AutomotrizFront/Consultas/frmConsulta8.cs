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
    public partial class frmConsulta8 : Form
    {
        public frmConsulta8()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // esto agregarlo al siguiente formulario
            string sp = "SP_8VACONSULTA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@MinCantidad", txtCantidad.Text.ToString()));

            dataGridView1.Rows.Clear();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, lst);
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] {
                    fila["cod_cliente"].ToString(),
                    fila["Cliente"].ToString(),
                    fila["cantidad"].ToString()});


            }
        }
    }
}
