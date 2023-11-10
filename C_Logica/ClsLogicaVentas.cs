using Proyecto3.C_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3.C_Logica
{
    internal class ClsLogicaVentas
    {
        public DataTable mostrar_tabla_venta()
        {
            ClsDatosVentas ventasD = new ClsDatosVentas();
            DataTable tabla = new DataTable();
            tabla = ventasD.tabla_ventas();
            return tabla;
        }
        public DataTable mostrar_busqueda(int id_recibo)
        {
            ClsDatosVentas productoD = new ClsDatosVentas();
            DataTable tabla = new DataTable();
            tabla = productoD.tabla_venta_selecionada(id_recibo);
            return tabla;
        }
    }
}
