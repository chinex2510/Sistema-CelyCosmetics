using Proyecto3.C_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3.C_Logica
{
    internal class ClsLogicaProd
    {
        private string codigo_producto_L;
        private string nombre_producto_L;
        private int stock_producto_L;
        private string fecha_vencimiento_producto_L;
        private double precio_unitario_producto_L;
        private string categoria_producto_L;

        public string Codigo_producto_L { get => codigo_producto_L; set => codigo_producto_L = value; }
        public string Nombre_producto_L { get => nombre_producto_L; set => nombre_producto_L = value; }
        public int Stock_producto_L { get => stock_producto_L; set => stock_producto_L = value; }
        public string Fecha_vencimiento_producto_L { get => fecha_vencimiento_producto_L; set => fecha_vencimiento_producto_L = value; }
        public double Precio_unitario_producto_L { get => precio_unitario_producto_L; set => precio_unitario_producto_L = value; }
        public string Categoria_producto_L { get => categoria_producto_L; set => categoria_producto_L = value; }

        //una funcion que realiza una clonacion de datos que se usara varias veces
        public ClsDatosProd PasarDatos(ClsLogicaProd p_Producto)//p_Producto por "Parametro_Producto"
        {
            ClsDatosProd productoD = new ClsDatosProd();
            productoD.Codigo_producto_D = p_Producto.Codigo_producto_L;
            productoD.Nombre_producto_D = p_Producto.Nombre_producto_L;
            productoD.Stock_producto_D = p_Producto.Stock_producto_L;
            productoD.Fecha_vencimiento_producto_D = p_Producto.Fecha_vencimiento_producto_L;
            productoD.Precio_unitario_producto_D = p_Producto.Precio_unitario_producto_L;
            productoD.Categoria_producto_D = p_Producto.Categoria_producto_L;
            return productoD;
        }
        //esta funcion retorna un objeto con todos los datos de un unico producto seleccionado 
        public ClsLogicaProd SelectProducto(string cod)
        {
            ClsDatosProd productoD = new ClsDatosProd();
            ClsLogicaProd oproducto = new ClsLogicaProd();
            oproducto = productoD.buscarProducto(cod);
            return oproducto;
        }

        public void CargarMod(ClsLogicaProd p_prodcto)
        {
            ClsDatosProd ProductoD = new ClsDatosProd();
            ProductoD.modificarDatos(PasarDatos(p_prodcto));
        }

        public void guardar(ClsLogicaProd p_Producto)
        {
            ClsDatosProd Productop = new ClsDatosProd();
            Productop.cargar_en_Sql(PasarDatos(p_Producto));
        }

        public DataTable mostrar_tabla()
        {
            ClsDatosProd productoD = new ClsDatosProd();
            DataTable tabla = new DataTable();
            tabla = productoD.tabla_producto();
            return tabla;
        }

        public void EliminarProducto(ClsLogicaProd p_producto)
        {
            ClsDatosProd ProductoD = new ClsDatosProd();
            ProductoD.eliminarProd(PasarDatos(p_producto));
        }
    }
}
