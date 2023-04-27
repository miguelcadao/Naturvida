using CapaDatos;
using CE_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Factura
    {
        private CD_Factura oCD_Factura = new CD_Factura();

        public string MostrarNFactura() 
        {
            string factura = oCD_Factura.MostrarNFactura();
            return factura;
        }

        public void InsertarFactura(CE_Factura factura) 
        {
            oCD_Factura.InsertarFactura(factura);
        }

        public void InsertarDetalleFactura(CE_Detalle_Factura factura) 
        {
            oCD_Factura.InsertarDetalleFactura(factura); 
        }

        public string BuscarCodigoVendedor(string vendedor)
        {
            string tabla = oCD_Factura.BuscarCodigoVendedor(vendedor);
            return tabla;
        }

        public void ActualizarCantidad(CE_Detalle_Factura factura) 
        {
            oCD_Factura.ActualizarCantidad(factura); 
        }

        public int TraerCantidad(CE_Detalle_Factura factura)
        {
            int tabla = oCD_Factura.TraerCantidad(factura);
            return tabla;
        }

    }
}
