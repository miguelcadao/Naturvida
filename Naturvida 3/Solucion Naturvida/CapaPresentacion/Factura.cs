using CapaNegocios;
using CE_Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Factura : Form
    {
        CN_Factura oCN_Factura = new CN_Factura();
        CN_Clientes oCN_Clientes = new CN_Clientes();
        CN_Productos oCN_Productos = new CN_Productos();

        DataTable tabla = new DataTable();
        int factura = 0;
        List<int> lista = new List<int>();
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            MostrarNFactura();
            MostrarDataGridView();
            MostrarClientes();
            MostrarProductos();
            BtnTerminarFactura.Enabled = false;
        }
        #region MIS METODOS

        private void MostrarNFactura()
        {
            if (oCN_Factura.MostrarNFactura() != " ")
            {
                factura = Convert.ToInt32(oCN_Factura.MostrarNFactura()) + 1;
                TxtNFactura.Text = factura.ToString();
            }
            else
                TxtNFactura.Text = 1.ToString();
        }

        private void MostrarDataGridView()
        {
            tabla.Columns.Add("Codigo producto");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Valor Unitario");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Subtotal");
            DgvProductosFactura.DataSource = tabla;
            DgvProductosFactura.Columns["Codigo producto"].Visible = false;

        }
        private void EliminarDataGridView()
        {
            DataTable dt = (DataTable)DgvProductosFactura.DataSource;
            dt.Clear();

        }

        private void MostrarClientes()
        {
            CboCliente.DataSource = oCN_Clientes.MostrarClientes();
            CboCliente.DisplayMember = "Nombre";
            CboCliente.ValueMember = "Documento";
            CboCliente.SelectedIndex = -1;
        }
        private void MostrarProductos()
        {
            CboProducto.DataSource = oCN_Productos.MostrarProductos();
            CboProducto.DisplayMember = "Descripción";
            CboProducto.ValueMember = "Codigo";
            CboProducto.SelectedIndex = -1;
        }

        private void LimpiarAgregar()
        {
            CboProducto.SelectedIndex = -1;
            TxtCantidad.Clear();
        }

        private int TotalFactura()
        {
            int Valor_total = 0;
            foreach (DataRow filas in tabla.Rows)
            {
                Valor_total += Convert.ToInt32(filas["Subtotal"]);
            }
            int valor = Valor_total;
            return valor;
        }
        private void LimpiarTodoFactura()
        {
            CboCliente.SelectedIndex = -1;
            CboProducto.SelectedIndex = -1;
            TxtCantidad.Clear();
            TxtTotal_Factura.Clear();
        }

        #endregion

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text != string.Empty &
                CboCliente.SelectedIndex != -1 &
                CboProducto.SelectedIndex != -1)
            {
                if (Convert.ToInt32(TxtCantidad.Text) > 0)
                {
                    CboCliente.Enabled = false;
                    int valor_unitario = 0;
                    CE_Detalle_Factura cantidad = new CE_Detalle_Factura();
                    CE_Productos productos = new CE_Productos();
                    DataRow filas = tabla.NewRow();
                    cantidad.Cod_Producto = Convert.ToInt32(CboProducto.SelectedValue);
                    int cant = Convert.ToInt32(oCN_Factura.TraerCantidad(cantidad));

                    if (cant - Convert.ToInt32(TxtCantidad.Text) >= 0)
                    {
                        filas["Producto"] = CboProducto.Text;
                        filas["Codigo producto"] = CboProducto.SelectedValue;

                        productos.Descripcion = CboProducto.Text;

                        valor_unitario = Convert.ToInt32(oCN_Productos.MostrarValorProducto(productos));
                        filas["Valor Unitario"] = valor_unitario;
                        filas["Cantidad"] = TxtCantidad.Text;
                        filas["Subtotal"] = Convert.ToInt32(TxtCantidad.Text) * Convert.ToInt32(oCN_Productos.MostrarValorProducto(productos).ToString());
                        int acumulador = 0;
                        int contador = 0;
                        bool respuesta = true;
                        foreach (DataRow fila in tabla.Rows)
                        {

                            contador++;
                            while (Convert.ToInt32(fila["Codigo producto"]) == Convert.ToInt32(CboProducto.SelectedValue))
                            {
                                acumulador = Convert.ToInt32(fila["Cantidad"]) + Convert.ToInt32(TxtCantidad.Text);
                                filas["Cantidad"] = acumulador;
                                DgvProductosFactura.Rows[contador - 1].Cells[3].Value = acumulador.ToString();
                                LimpiarAgregar();
                                respuesta = false;
                                break;
                            }

                        }
                        if (respuesta == true)
                        {
                            tabla.Rows.Add(filas);
                            TxtTotal_Factura.Text = TotalFactura().ToString();
                            LimpiarAgregar();
                            BtnTerminarFactura.Enabled = true;

                        }

                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente de este producto");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede agregar un producto sin cantidad");
                }
            }
            else
            {
                MessageBox.Show("No se puede agregar el producto");
            }
        }

        private void BtnTerminarFactura_Click(object sender, EventArgs e)
        {
            CE_Factura factura = new CE_Factura();
            CE_Detalle_Factura Detalle_factura = new CE_Detalle_Factura();

            factura.Fecha_Factura = DtpFecha_Factura.Value;
            factura.Doc_Cliente = Convert.ToInt32(CboCliente.SelectedValue);
            factura.Cod_Vendedor = Convert.ToInt32(oCN_Factura.BuscarCodigoVendedor(CP_GOLBAL.CP_vendedores.vendedor1));

            oCN_Factura.InsertarFactura(factura);
            foreach (DataRow filas in tabla.Rows)
            {
                Detalle_factura.Cod_Producto = Convert.ToInt32(filas["Codigo producto"]);
                Detalle_factura.Cantidad = Convert.ToInt32(filas["Cantidad"]);
                oCN_Factura.ActualizarCantidad(Detalle_factura);

                Detalle_factura.Cod_Producto = Convert.ToInt32(filas["Codigo producto"]);
                Detalle_factura.Id_Factura = Convert.ToInt32(TxtNFactura.Text);
                Detalle_factura.Cantidad = Convert.ToInt32(filas["Cantidad"]);
                Detalle_factura.Valor_Unidad = Convert.ToInt32(filas["Valor Unitario"]);
                oCN_Factura.InsertarDetalleFactura(Detalle_factura);
            }
            CboCliente.Enabled = true;
            BtnTerminarFactura.Enabled = false;


            MostrarNFactura();
            EliminarDataGridView();
            LimpiarTodoFactura();
        }
        CN_Validaciones validaciones = new CN_Validaciones();
        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNum(e);

        }

    }
}
