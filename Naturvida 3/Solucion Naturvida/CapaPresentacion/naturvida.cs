using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class naturvida : Form
    {
        public naturvida()
        {
            InitializeComponent();
        }

        

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor= Color.Coral;
            Form Gestion_productos = new Gestion_productos();
            Abrir(Gestion_productos);
        }
        private void Abrir(Form hijo)
        {
            this.panel1.Controls.Clear();//limpiar el panel
            //Form2 hijo = new Form2();//instanciar
            hijo.TopLevel = false;//para que no sea mas grande que el panel
            hijo.Dock = DockStyle.Fill;///dar formato completo
            this.panel1.Controls.Add(hijo);//agregar el formulario que esta en hijo
            hijo.Show();
        }

        private void naturvida_Load(object sender, EventArgs e)
        {
            Form presentacion = new Presentacion();
            Abrir(presentacion);
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Aqua;
            Form factura = new Factura();
            Abrir(factura);
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.SandyBrown;
            Form vendedores = new Vendedores();
            Abrir(vendedores);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGreen;
            Form clientes= new Clientes();
            Abrir(clientes);
        }

        private void consultarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor= Color.CornflowerBlue;
            Form inventario = new Inventario();
            Abrir(inventario);
        }

        private void inicioSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form inicio_sesion = new Form1();
            inicio_sesion.Show();
            Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
