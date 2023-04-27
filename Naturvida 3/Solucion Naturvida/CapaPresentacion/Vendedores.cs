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
    public partial class Vendedores : Form
    {
        CE_Vendedores vendedores = new CE_Vendedores();
        CN_Vendedores oCN_Vendedores = new CN_Vendedores();
        CN_Validaciones validaciones = new CN_Validaciones();

        public Vendedores()
        {
            InitializeComponent();
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            mostrartodoseditarvendedores();
            Limpiar();
            mostrarnombrevendedor();
            editarmostrarnombrevendedor();
            eliminarmostrarnombrevendedor();
        }

        #region Mis métodos

        private void Limpiar()
        {
            Txtingresar_vendedor_codigo.Clear();
            Txtingresar_vendedor_usuario.Clear();
            Txtingresar_vendedor_contrasena.Clear();
            Txtingresar_vendedor_nombre.Clear();
            TxtRepetir_Contraseña.Clear();
        }

        private void LimpiarEditar()
        {
            Txtmodificar_vendedor_codigo.Clear();
            Txtmodificar_vendedor_usuario.Clear();
            Txtmodificar_vendedor_nombre.Clear();
            Txtmodificar_vendedor_contrasena.Clear();
        }

        private void mostrarnombrevendedor() //Muestra el usuario de los vendedores en el combobox de consultar
        {
            Cbxconsultar_vendedor_vendedor.DataSource = oCN_Vendedores.mostrartodatablavend();
            Cbxconsultar_vendedor_vendedor.DisplayMember = "Usuario";
            Cbxconsultar_vendedor_vendedor.ValueMember = "Codigo";
            Cbxconsultar_vendedor_vendedor.SelectedIndex = -1;
        }

        private void eliminarmostrarnombrevendedor()
        {
            Cboeliminar_vendedor_usuario.DataSource = oCN_Vendedores.mostrartodatablavend();
            Cboeliminar_vendedor_usuario.DisplayMember = "Usuario";
            Cboeliminar_vendedor_usuario.ValueMember = "Codigo";
            Cboeliminar_vendedor_usuario.SelectedIndex = -1;
        }

        private void editarmostrarnombrevendedor()
        {
            Cbomodificar_vendedor_usuario.DataSource = oCN_Vendedores.mostrartodatablavend();
            Cbomodificar_vendedor_usuario.DisplayMember = "Usuario";
            Cbomodificar_vendedor_usuario.ValueMember = "Codigo";
            Cbomodificar_vendedor_usuario.SelectedIndex = -1;
        }

        private void mostrartodosvendedores() //Muestra el producto del combobox en el datagridview de consultar
        {
            vendedores.Codigo = Convert.ToInt32(Cbxconsultar_vendedor_vendedor.SelectedValue);
            Dgwconsultarvendedor.DataSource = oCN_Vendedores.BuscarTodosvend(vendedores);
        }

        private void mostrartodoseditarvendedores()
        {
            CE_Vendedores vendedores = new CE_Vendedores();
            vendedores.Codigo = Convert.ToInt32(Cbomodificar_vendedor_usuario.SelectedValue);
            dataGridView1.DataSource = oCN_Vendedores.mostrartodatablavend();
            dataGridView1.Visible = false;
        }

        private void mosstrartablatodovendedores()
        {
            Dgwconsultarvendedor.DataSource = oCN_Vendedores.mostrartodatablavend();
            Cbxconsultar_vendedor_vendedor.SelectedIndex = -1;
        }

        #endregion



        private void Btningresa_vendedor_guardar_Click(object sender, EventArgs e)
        {
            CN_Validaciones encriptacion = new CN_Validaciones();

            if (Txtingresar_vendedor_codigo.Text == string.Empty ||
                Txtingresar_vendedor_usuario.Text == string.Empty ||
                Txtingresar_vendedor_contrasena.Text == string.Empty ||
                Txtingresar_vendedor_nombre.Text == string.Empty)
            {
                MessageBox.Show("Error ingrese los datos");
            }
            else
            {
                vendedores.Codigo = Convert.ToInt32(Txtingresar_vendedor_codigo.Text); ;
                vendedores.Usuario = Txtingresar_vendedor_usuario.Text;

                if (oCN_Vendedores.BuscarVend(vendedores) == false)
                {
                    vendedores.Codigo = Convert.ToInt32(Txtingresar_vendedor_codigo.Text);
                    vendedores.Usuario = Txtingresar_vendedor_usuario.Text;
                    vendedores.Contraseña = encriptacion.Encriptacion(Txtingresar_vendedor_contrasena.Text);
                    vendedores.Nombre = Txtingresar_vendedor_nombre.Text;
                    if (Txtingresar_vendedor_contrasena.Text == TxtRepetir_Contraseña.Text)
                    {
                        oCN_Vendedores.InsertarVend(vendedores);
                        MessageBox.Show("Se ingresó correctamente el vendedor");
                        Limpiar();

                        mostrarnombrevendedor();
                        mostrartodoseditarvendedores();
                        editarmostrarnombrevendedor();
                        eliminarmostrarnombrevendedor();
                    }

                    else
                    {
                        MessageBox.Show("Error las contraseñas no coinciden");
                    }
                }

                else
                {
                    MessageBox.Show("El vendedor ya existe");
                }

            }
        }


        private void Btnmodificar_vendedor_guardarcambios_Click(object sender, EventArgs e)
        {
            if (Txtmodificar_vendedor_codigo.Text == string.Empty ||
                Txtmodificar_vendedor_usuario.Text == string.Empty ||
                Txtmodificar_vendedor_nombre.Text == string.Empty ||
                Txtmodificar_vendedor_contrasena.Text==string.Empty)
            {
                MessageBox.Show("Error ingrese los datos");
            }
            else
            {
                vendedores.Codigo = Convert.ToInt32(Txtmodificar_vendedor_codigo.Text);
                vendedores.Usuario = Txtmodificar_vendedor_usuario.Text;
                if (oCN_Vendedores.BuscarVendEditar(vendedores) == false)
                {
                    vendedores.Codigo = Convert.ToInt32(Txtmodificar_vendedor_codigo.Text);
                    vendedores.Usuario = Txtmodificar_vendedor_usuario.Text;
                    vendedores.Nombre = Txtmodificar_vendedor_nombre.Text;
                    vendedores.Contraseña = validaciones.Encriptacion(Txtingresar_vendedor_contrasena.Text);

                    oCN_Vendedores.EditarVend(vendedores);
                    
                        MessageBox.Show("Se editó correctamente");
                        mostrartodoseditarvendedores();
                        mostrarnombrevendedor();
                        editarmostrarnombrevendedor();
                        eliminarmostrarnombrevendedor();
                        LimpiarEditar();
                                       
                }
                else
                {
                    MessageBox.Show("El vendedor ya existe");
                }
            }
        }

        private void Btningresar_vendedor_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Btn_consultar_vendedor_consultar_Click(object sender, EventArgs e)
        {
            mostrartodosvendedores();
            mostrarnombrevendedor();


        }

        private void Btnconsultar_vendedor_mostrarvendedor_Click(object sender, EventArgs e)
        {
            mosstrartablatodovendedores();
        }

        private void Btnmodificar_vendedor_consultar_Click(object sender, EventArgs e)
        {
            mostrartodoseditarvendedores();
            if (Cbomodificar_vendedor_usuario.SelectedIndex >= 0)
            {
                Txtmodificar_vendedor_codigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                Txtmodificar_vendedor_usuario.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();               
                Txtmodificar_vendedor_nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            mostrarnombrevendedor();
            editarmostrarnombrevendedor();
            eliminarmostrarnombrevendedor();
            mostrartodoseditarvendedores();
        }

        private void Btneliminar_vendedor_vendedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres eliminar", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vendedores.Codigo = Convert.ToInt32(Cboeliminar_vendedor_usuario.SelectedValue);
                oCN_Vendedores.eliminarvend(vendedores);
                Cboeliminar_vendedor_usuario.SelectedIndex = -1;
                MessageBox.Show("Se eliminó correctamente");
                mostrartodoseditarvendedores();
                mostrarnombrevendedor();
                editarmostrarnombrevendedor();
                eliminarmostrarnombrevendedor();
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación");
            }
        }

        #region Validaciones
        private void Txtingresar_vendedor_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNum(e);
        }
        private void Txtingresar_vendedor_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }
        private void Txtmodificar_vendedor_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);

        }
        #endregion

    }
}
