using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.C_Datos
{
    internal class ClsDatosVentas
    {

        static string servidor = "127.0.0.1";
        static string bd = "celycosmetic";
        static string usuario = "root";
        static string password = "12345";//<--- actualizar con la contraseña de su base de datos 
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public DataTable tabla_ventas()
        {
            //Creamos una funcion de tipo tabla
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string cadena = "SELECT     rv.Recibo_Venta_Numero AS Recibo, " +
                    "   rv.Fecha_Emision AS Fecha,    SUM(dr.Cantidad_Vendida) AS Articulos, " +
                    "   rv.Total_Recibo AS Total,    rv.Cliente_DNI AS DNI FROM     Recibo_Venta rv JOIN " +
                    "    Detalle_Recibo dr ON rv.Recibo_Venta_Numero = dr.Recibo_Venta_Numero GROUP BY  " +
                    "   rv.Recibo_Venta_Numero, rv.Fecha_Emision, rv.Total_Recibo, rv.Cliente_DNI;";
                MySqlDataReader leer_filasSQL; //SqlDataReader <-- Lee un flujo de filas unicamente de SQL
                DataTable tabla_SQL = new DataTable();// Creamos un objeto te tipo tabla
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                leer_filasSQL = comando.ExecuteReader();//<-- se guarda el comando executado la variable leer Filas
                tabla_SQL.Load(leer_filasSQL);//<-- Se lee las filas guardadas en la variable 
                conexion.Close();
                return tabla_SQL;//<-- Retornamos la tabla cargada
            }
            catch
            {
                MessageBox.Show("Hubo un error en el intento de Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable tabla_venta_selecionada(int num_recibo)
        {
            //Creamos una funcion de tipo tabla
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string cadena = "SELECT rv.Recibo_Venta_Numero AS Recibo, " +
                    "   rv.Fecha_Emision AS Fecha,    SUM(dr.Cantidad_Vendida) AS Articulos, " +
                    "   rv.Total_Recibo AS Total,    rv.Cliente_DNI AS DNI FROM     Recibo_Venta rv JOIN " +
                    "    Detalle_Recibo dr ON rv.Recibo_Venta_Numero = dr.Recibo_Venta_Numero" +
                    $" where rv.Recibo_Venta_Numero = {num_recibo} GROUP BY  " +
                    "   rv.Recibo_Venta_Numero, rv.Fecha_Emision, rv.Total_Recibo, rv.Cliente_DNI;";
                MySqlDataReader leer_filasSQL; //SqlDataReader <-- Lee un flujo de filas unicamente de SQL
                DataTable tabla_SQL = new DataTable();// Creamos un objeto te tipo tabla
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                leer_filasSQL = comando.ExecuteReader();//<-- se guarda el comando executado la variable leer Filas
                tabla_SQL.Load(leer_filasSQL);//<-- Se lee las filas guardadas en la variable 
                conexion.Close();
                return tabla_SQL;//<-- Retornamos la tabla cargada
            }
            catch
            {
                MessageBox.Show("Hubo un error en el intento de Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
