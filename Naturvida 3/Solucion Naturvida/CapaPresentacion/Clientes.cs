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
using CapaNegocios;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace CapaPresentacion
{
    public partial class Clientes : Form
    {
        CN_Validaciones validaciones = new CN_Validaciones();
        CN_Clientes oCN_Clientes =new CN_Clientes();
        CE_Clientes clientes = new CE_Clientes();
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            mostrartodoseditarclientes();
            Limpiar();
            mostrarnombrecliente();
            editarmostrarnombrecliente();
            eliminarmostrarnombrecliente();
        }
        #region METODOS
        private void Limpiar()
        {
            Txtingresar_Cliente_documento.Clear();
            Txtingresar_cliente_nombre.Clear();
            Txtingresar_Cliente_direccion.Clear();
            Txtingresar_Cliente_telefono.Clear();
            Txtingresar_Cliente_correo.Clear();
        }

        private void LimpiarEditar()
        {
            Txtmodificar_Cliente_nombre.Clear();
            Txtmodificar_Cliente_Documento.Clear();
            Txtmodificar_Cliente_Direccion.Clear();
            Txtmodificar_Cliente_telefono.Clear();
            Txtmodificar_Cliente_correo.Clear();
        }

        private void mostrarnombrecliente() //Muestra el nombre de los clientes en el combobox de consultar
        {
            Cbxconsultar_Cliente_cliente.DataSource = oCN_Clientes.MostrarClientes();
            Cbxconsultar_Cliente_cliente.DisplayMember = "Nombre";
            Cbxconsultar_Cliente_cliente.ValueMember = "Documento";
            Cbxconsultar_Cliente_cliente.SelectedIndex = -1;
        }

        private void eliminarmostrarnombrecliente() //Muestra el nombre de los clientes en el combobox de eliminar
        {
            Cboeliminar_Cliente.DataSource = oCN_Clientes.MostrarClientes();
            Cboeliminar_Cliente.DisplayMember = "Nombre";
            Cboeliminar_Cliente.ValueMember = "Documento";
            Cboeliminar_Cliente.SelectedIndex = -1;
        }

        private void editarmostrarnombrecliente() //Muestra el nombre de los clientes en el combobox de editar
        {
            Cbomodificar_clientes_nombre.DataSource = oCN_Clientes.MostrarClientes();
            Cbomodificar_clientes_nombre.DisplayMember = "Nombre";
            Cbomodificar_clientes_nombre.ValueMember = "Documento";
            Cbomodificar_clientes_nombre.SelectedIndex = -1;
        }

        private void mostrartodoscliente() //Muestra el cliente del combobox en el datagridview de consultar
        {
            
            clientes.Documento = Convert.ToInt32(Cbxconsultar_Cliente_cliente.SelectedValue);
            Dgwconsultarclientes.DataSource = oCN_Clientes.BuscarTodoscliente(clientes);
        }

        private void mostrartodoseditarclientes() //Muestra todos los clientes en el datagridwiew escondido para modificar
        {
            CE_Clientes clientes = new CE_Clientes();
            clientes.Documento = Convert.ToInt32(Cbomodificar_clientes_nombre.SelectedValue);
            dataGridView11.DataSource = oCN_Clientes.mostrartodatablaclienteeditar(clientes);
            dataGridView11.Visible = false;
        }

        private void mosstrartablatodoclientes() //Muestra todos los clientes en el datadrid view de consultar
        {
            Dgwconsultarclientes.DataSource = oCN_Clientes.mostrartodatablacliente();
            Cbxconsultar_Cliente_cliente.SelectedIndex = -1;
        }


        #endregion
        private void Btningresa_Cliente_guardar_Click(object sender, EventArgs e)
        {
            if (Txtingresar_Cliente_correo.Text == string.Empty ||
                Txtingresar_Cliente_direccion.Text == string.Empty ||
                Txtingresar_Cliente_telefono.Text == string.Empty ||
                Txtingresar_cliente_nombre.Text == string.Empty||
                Txtingresar_Cliente_documento.Text == string.Empty)
            {
                MessageBox.Show("Error ingrese los datos");
            }
            else
            {
                clientes.Documento = Convert.ToInt32(Txtingresar_Cliente_documento.Text);
                clientes.Correo = Txtingresar_Cliente_correo.Text;

                if (oCN_Clientes.Buscarclientes(clientes) == false)
                {
                    clientes.Documento = Convert.ToInt32(Txtingresar_Cliente_documento.Text);
                    clientes.Nombre = (Txtingresar_cliente_nombre.Text);
                    clientes.Direccion = Txtingresar_Cliente_direccion.Text;
                    clientes.Telefono = Txtingresar_Cliente_telefono.Text;
                    clientes.Correo = Txtingresar_Cliente_correo.Text;

                    if (validaciones.correo(Txtingresar_Cliente_correo.Text) == false)
                    {
                        MessageBox.Show("No es valido el correo");
                    }

                    else
                    {
                        oCN_Clientes.insertarcliente(clientes);
                        MessageBox.Show("Se ingresó correctamente el cliente");
                        Limpiar();

                        mostrartodoseditarclientes();
                        mostrarnombrecliente();
                        editarmostrarnombrecliente();
                        eliminarmostrarnombrecliente();
                    }

                }
                else
                {
                    MessageBox.Show("El cliente ya existe");
                }

            }
        }

        private void Btningresar_Cliente_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Btn_consultar_Cliente_consultar_Click(object sender, EventArgs e)
        {
            mostrartodoscliente();
        }

        private void Btnconsultar_Cliente_mostrarvendedor_Click(object sender, EventArgs e)
        {
            mosstrartablatodoclientes();
           
        }

        private void Btnmodificar_Cliente_consultar_Click(object sender, EventArgs e)
        {
            mostrartodoseditarclientes();
            if (Cbomodificar_clientes_nombre.SelectedIndex >= 0)
            {
                Txtmodificar_Cliente_Documento.Text = dataGridView11.CurrentRow.Cells["Documento"].Value.ToString();
                Txtmodificar_Cliente_nombre.Text = dataGridView11.CurrentRow.Cells["Nombre"].Value.ToString();
                Txtmodificar_Cliente_Direccion.Text = dataGridView11.CurrentRow.Cells["Direccion"].Value.ToString();
                Txtmodificar_Cliente_telefono.Text = dataGridView11.CurrentRow.Cells["Telefono"].Value.ToString();
                Txtmodificar_Cliente_correo.Text = dataGridView11.CurrentRow.Cells["Correo"].Value.ToString();
            }
            mostrarnombrecliente();
            editarmostrarnombrecliente();
            eliminarmostrarnombrecliente();
            mostrartodoseditarclientes();

        }

        private void Btnmodificar_Cliente_guardar_Click(object sender, EventArgs e)
        {

            if (Txtmodificar_Cliente_Documento.Text == string.Empty ||
                Txtmodificar_Cliente_nombre.Text == string.Empty ||
                Txtmodificar_Cliente_Direccion.Text == string.Empty ||
                Txtmodificar_Cliente_telefono.Text == string.Empty||
                Txtmodificar_Cliente_correo.Text == string.Empty)
            {
                MessageBox.Show("Error ingrese los datos");
            }
            else
            {
                if (validaciones.correo(Txtmodificar_Cliente_correo.Text) == false)
                {
                    MessageBox.Show("No es valido el correo");
                }

                else
                {
                    clientes.Documento = Convert.ToInt32(Txtmodificar_Cliente_Documento.Text);
                    clientes.Correo = Txtmodificar_Cliente_correo.Text;

                    if (oCN_Clientes.BuscarclientesEditar(clientes) == false)
                    {
                        clientes.Documento = Convert.ToInt32(Txtmodificar_Cliente_Documento.Text);
                        clientes.Nombre = Txtmodificar_Cliente_nombre.Text;
                        clientes.Direccion = Txtmodificar_Cliente_Direccion.Text;
                        clientes.Telefono = Txtmodificar_Cliente_telefono.Text;
                        clientes.Correo = Txtmodificar_Cliente_correo.Text;
                        oCN_Clientes.Editarcliente(clientes);
                        MessageBox.Show("Se editó correctamente");
                        mostrartodoseditarclientes();
                        mostrarnombrecliente();
                        editarmostrarnombrecliente();
                        eliminarmostrarnombrecliente();
                        LimpiarEditar();
                    }
                    else
                    {
                        MessageBox.Show("El cliente ya existe");
                    }
                }
            }
        }

        private void Btneliminar_Cliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres eliminar", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clientes.Documento = Convert.ToInt32(Cboeliminar_Cliente.SelectedValue);
                oCN_Clientes.eliminarclientes(clientes);
                Cboeliminar_Cliente.SelectedIndex = -1;
                MessageBox.Show("Se eliminó correctamente");
                mostrartodoseditarclientes();
                mostrarnombrecliente();
                editarmostrarnombrecliente();
                eliminarmostrarnombrecliente();
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación");
            }
        }
        #region validaciones
        private void Txtingresar_Cliente_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNum(e);
        }

        private void Txtingresar_cliente_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }

        private void Txtingresar_Cliente_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNum(e);
        }

        private void Txtmodificar_Cliente_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }

        private void Txtmodificar_Cliente_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNum(e);
        }

        private void Txtingresar_Cliente_correo_TextChanged(object sender, EventArgs e)
        {
            validaciones.correo(Convert.ToString(e).ToLower().Trim());
            validaciones.email(Convert.ToString(e).ToLower().Trim());
        }
        #endregion

    }
}
