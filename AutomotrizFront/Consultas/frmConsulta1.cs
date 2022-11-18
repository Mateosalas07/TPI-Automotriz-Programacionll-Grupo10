using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizApp.Datos;
 

namespace AutomotrizFront
{
    public partial class frmConsulta1 : Form
    {
        public frmConsulta1()
        {
            InitializeComponent();
        }

        private void txtConsultar_Click(object sender, EventArgs e)
        {
            // esto agregarlo al siguiente formulario
            string sp = "SP_1ERCONSULTA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@color",cboColor.Text.ToString() ));

            dgvConsulta1.Rows.Clear();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultaSQL(sp, lst);
            foreach (DataRow fila in dt.Rows)
            {
                dgvConsulta1.Rows.Add(new object[] {
                    fila["id_Vehículo"].ToString(),
                    fila["Marca"].ToString(),
                    fila["Modelo"].ToString(),
                    fila["Tipo de Vehículo"].ToString(),                 
                    int.Parse(fila["Precio"].ToString()),
                    fila["Color"].ToString(),
                    fila["Año"].ToString()});
            
            
            }
            
        }
    }
}
