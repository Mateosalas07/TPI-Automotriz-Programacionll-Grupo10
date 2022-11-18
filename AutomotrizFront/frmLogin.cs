using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizApp.Dominio;
using AutomotrizFront;
using AutomotrizFront.Http;
using Newtonsoft.Json;

namespace AutomotrizApp.formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario login = new Usuario();
            login.Nombre = txtUsuario.Text.ToString();
            login.Contraseña = txtPass.Text.ToString();
            ConsultarUsuario(login);


        }

        private async void ConsultarUsuario(Usuario login)
        {
            string bodyContent = JsonConvert.SerializeObject(login);

            string url = "https://localhost:5001/Usuarios";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);
            //return result;

            if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)
            {
                //MessageBox.Show("", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenu ofrmMenu = new frmMenu();

                ofrmMenu.ShowDialog();
                //this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. Usuario o Contraseña Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
