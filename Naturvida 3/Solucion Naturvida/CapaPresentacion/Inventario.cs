using CapaNegocios;
using CE_Entidades;
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
    public partial class Inventario : Form
    {
        CN_Productos inventario = new CN_Productos();
        CE_Productos inventario1 = new CE_Productos();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            mostrarnombreproducto();
        }

        #region Mis Métodos
        private void mostrarnombreproducto()
        {
            Cbo_Inventario_Producto.DataSource = inventario.MostrarProductos();
            Cbo_Inventario_Producto.DisplayMember = "Descripción";
            Cbo_Inventario_Producto.ValueMember = "Codigo";
            Cbo_Inventario_Producto.SelectedIndex = -1;
        }

        private void MostrarInventarioConsultar()
        {
            
            inventario1.Codigo = Convert.ToInt32(Cbo_Inventario_Producto.SelectedValue);
            Dgv_Inventario.DataSource = inventario.MostrarInventarioConsultar(inventario1);
        }


        private void MostrarInventarioMostrarTodo()
        {
            Dgv_Inventario.DataSource = inventario.MostrarInventarioMostrarTodo();
        }

        #endregion

        private void Btn_Inventario_Consultar_Click(object sender, EventArgs e)
        {
            MostrarInventarioConsultar();
        }

        private void Btn_MInventario_Mostrar_Todo_Click(object sender, EventArgs e)
        {
            MostrarInventarioMostrarTodo();
        }
    }
}
