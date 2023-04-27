using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CE_Entidades;
using CapaNegocios;
using CapaPresentacion.Properties;
using System.Security.Cryptography.X509Certificates;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        CE_Vendedores vendedores = new CE_Vendedores();
        CN_Validaciones validacion = new CN_Validaciones();
        CN_Vendedores oCN_Vendedores = new CN_Vendedores();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {            
            CP_GOLBAL.CP_vendedores.vendedor1 = TxtLogin.Text;
            vendedores.Usuario = TxtLogin.Text.Trim();            
            vendedores.Contraseña = validacion.Encriptacion(TxtContraseña.Text.ToLower().Trim());            

            if (oCN_Vendedores.buscardatovende(vendedores) == true)
            {
                Form Gestion_productos = new naturvida();
                Gestion_productos.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Datos incorrectos");

            }
        }
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
