using Proyecto3.C_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3.C_Logica
{
    internal class ClsLogicaFactura
    {
        private string codprod;
        private string producto;
        private double precio;
        private string fecha;
        private int cantidad;
        private int dni;
        private int numFactura;
        private double descuento;
        private double subtotal;
        private double precioTotal;

        public string Codprod { get => codprod; set => codprod = value; }
        public string Producto { get => producto; set => producto = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Dni { get => dni; set => dni = value; }
        public int NumFactura { get => numFactura; set => numFactura = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double PrecioTotal { get => precioTotal; set => precioTotal = value; }

        public ClsLogicaFactura selectProd(string cod)
        {
            ClsDatosFactura productoD = new ClsDatosFactura();
            ClsLogicaFactura oproducto = new ClsLogicaFactura();
            oproducto = productoD.MostrarProducto(cod);
            return oproducto;
        }
        public ClsLogicaFactura selectCliente(string dni)
        {
            ClsDatosFactura clienteD = new ClsDatosFactura();
            ClsLogicaFactura ocliente = new ClsLogicaFactura();
            ocliente = clienteD.SeleccionarCliente(dni);
            return ocliente;
        }
        public ClsLogicaFactura numFac(int num)
        {
            ClsDatosFactura datosFacturaD = new ClsDatosFactura();
            ClsLogicaFactura odatosFactura = new ClsLogicaFactura();
            odatosFactura = datosFacturaD.mostrarNum(num);
            return odatosFactura;

        }

        public void GuardarRecibo(ClsLogicaFactura p_reciborealizado)
        {
            ClsDatosFactura VentaR = new ClsDatosFactura();
            VentaR.InsertarReciboVenta(PasarDatosRecibo(p_reciborealizado));

        }
        public void guardar(ClsLogicaFactura p_ventarealizada)
        {
            ClsDatosFactura VentaR = new ClsDatosFactura();
            VentaR.InsertarDetalleRecibo(PasarDatosFactura(p_ventarealizada), p_ventarealizada.NumFactura); // Insertar en detalle_recibo
            VentaR.actualizarStockVenta(PasarDatosFactura(p_ventarealizada), p_ventarealizada.NumFactura);
        }

        public ClsDatosFactura PasarDatosFactura(ClsLogicaFactura p_ventarealizada)
        {
            ClsDatosFactura ventaN = new ClsDatosFactura();
            ventaN.Subtotal_D = p_ventarealizada.Subtotal;
            ventaN.Cantidad_D = p_ventarealizada.Cantidad;
            ventaN.Precio_D = p_ventarealizada.Precio;
            ventaN.NumeroFactura_D = p_ventarealizada.NumFactura;
            ventaN.Codprod_D = p_ventarealizada.Codprod;

            return ventaN;
        }
        public ClsDatosFactura PasarDatosRecibo(ClsLogicaFactura p_reciborealizado)
        {
            ClsDatosFactura ventaN = new ClsDatosFactura();
            ventaN.Dni_D = p_reciborealizado.Dni;
            ventaN.Precio_total_D = p_reciborealizado.PrecioTotal;
            ventaN.Descuento_D = p_reciborealizado.Descuento;

            return ventaN;
        }
    }
}
