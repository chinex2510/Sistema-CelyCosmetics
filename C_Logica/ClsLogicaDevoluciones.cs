using Proyecto3.C_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3.C_Logica
{
    internal class ClsLogicaDevoluciones
    {
        private string codProd_L;
        private int stock_L;
        private int num_Recibo_L;

        public string CodProd_L { get => codProd_L; set => codProd_L = value; }
        public int Stock_L { get => stock_L; set => stock_L = value; }
        public int Num_Recibo_L { get => num_Recibo_L; set => num_Recibo_L = value; }


        public ClsDatosDevoluciones PasarDatos(ClsLogicaDevoluciones p_Dev)//p_Producto por "Parametro_Producto"
        {
            ClsDatosDevoluciones devD = new ClsDatosDevoluciones();
            devD.CodProd_D = p_Dev.CodProd_L;
            devD.Stock_D = p_Dev.Stock_L;
            devD.Num_Recibo_D = p_Dev.Num_Recibo_L;
            return devD;
        }
        public void CargarMod(ClsLogicaDevoluciones p_prodcto)
        {
            ClsDatosDevoluciones ProductoD = new ClsDatosDevoluciones();
            ProductoD.modificarDatos(PasarDatos(p_prodcto));
        }



        public DataTable mostrar_busqueda(int id_recibo)
        {
            ClsDatosDevoluciones detalleD = new ClsDatosDevoluciones();
            DataTable tabla = new DataTable();
            tabla = detalleD.tabla_venta_selecionada(id_recibo);
            return tabla;
        }
    }
}
