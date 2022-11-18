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
    public partial class frmConsulta3 : Form
    {
        public frmConsulta3()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //// esto agregarlo al siguiente formulario
            //string sp = "SP_3erConsulta";
            //List<Parametro> lst = new List<Parametro>();
            //lst.Add(new Parametro("@cantidad1", txtDesde.Text.ToString()));
            //lst.Add(new Parametro("@cantidad2", txtHasta.Text.ToString()));

            //dataGridView1.Rows.Clear();
            //DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, lst);
            //foreach (DataRow fila in dt.Rows)
            //{
            //    dataGridView1.Rows.Add(new object[] {
            //        fila["cod_cliente"].ToString(),
            //        fila["Nombre Completo"].ToString(),
            //        fila["Tipo de Cliente"].ToString(),
            //        fila["Cantidad"].ToString()});


            //}
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            // esto agregarlo al siguiente formulario
            string sp = "SP_3erConsulta";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@cantidad1", txtDesde.Text.ToString()));
            lst.Add(new Parametro("@cantidad2", txtHasta.Text.ToString()));

            dataGridView1.Rows.Clear();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, lst);
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] {
                    fila["cod_cliente"].ToString(),
                    fila["Nombre Completo"].ToString(),
                    fila["Tipo de Cliente"].ToString(),
                    fila["Cantidad"].ToString()});


            }
        }
    }
}
