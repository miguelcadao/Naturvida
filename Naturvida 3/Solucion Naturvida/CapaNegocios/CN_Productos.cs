using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CE_Entidades;

namespace CapaNegocios
{
    public class CN_Productos
    {
        CD_Productos oCD_Productos = new CD_Productos();
        DataTable tabla = new DataTable();
        public bool BuscarProd(CE_Productos productos)
        {
            DataTable encontrado = oCD_Productos.BuscarProducto(productos);
            if (encontrado.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }

        public bool BuscarProdEditar(CE_Productos productos)
        {
            DataTable encontrado = oCD_Productos.BuscarProductoEditar(productos);
            if (encontrado.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }
        public void eliminarprod(CE_Productos productos)
        {
            oCD_Productos.eliminarproducto(productos);
        }

        public void InsertarProd(CE_Productos productos)
        {
            oCD_Productos.InsertarProductos(productos);
        }

        public void EditarProd(CE_Productos productos)
        {
            oCD_Productos.EditarProductos(productos);
        }
        public DataTable Buscarnombreprod()
        {
            DataTable tabla = oCD_Productos.BuscarnombreProducto();
            return tabla;
        }

        public DataTable BuscarTodosprod(CE_Productos productos)
        {
            DataTable tabla = oCD_Productos.BuscarTodosProducto(productos);
            return tabla;
        }

        public DataTable mostrartodatablaprod()
        {
            DataTable tabla = oCD_Productos.mostrartodatablaproductos();
            return tabla;
        }

        public DataTable mostrartodatablaproductoeditar(CE_Productos productos)
        {
            DataTable tabla3 = oCD_Productos.mostrartodatablaproductoseditar(productos);
            return tabla3;
        }

        public DataTable MostrarProductos()
        {            
            tabla = oCD_Productos.MostrarProductos();
            return tabla;
        }

        public DataTable MostrarInventarioConsultar(CE_Productos inventario)
        {            
            tabla = oCD_Productos.MostrarInventarioConsultar(inventario);
            return tabla;
        }

        public DataTable MostrarInventarioMostrarTodo()
        {
            
            tabla = oCD_Productos.MostrarInventarioMostrarTodo();
            return tabla;
        }
        public string MostrarValorProducto(CE_Productos producto)
        {
            string tabla = oCD_Productos.MostrarValorProducto(producto);
            return tabla;
        }
    }
}
