using MySql.Data.MySqlClient;
using Proyecto3.C_Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.C_Datos
{
    internal class ClsDatosProd
    {
        private string codigo_producto_D;
        private string nombre_producto_D;
        private int stock_producto_D;
        private string fecha_vencimiento_producto_D;
        private double precio_unitario_producto_D;
        private string categoria_producto_D;

        public string Codigo_producto_D { get => codigo_producto_D; set => codigo_producto_D = value; }
        public string Nombre_producto_D { get => nombre_producto_D; set => nombre_producto_D = value; }
        public int Stock_producto_D { get => stock_producto_D; set => stock_producto_D = value; }
        public string Fecha_vencimiento_producto_D { get => fecha_vencimiento_producto_D; set => fecha_vencimiento_producto_D = value; }
        public double Precio_unitario_producto_D { get => precio_unitario_producto_D; set => precio_unitario_producto_D = value; }
        public string Categoria_producto_D { get => categoria_producto_D; set => categoria_producto_D = value; }

        static string servidor = "127.0.0.1";
        static string bd = "celycosmetic";
        static string usuario = "root";
        static string password = "12345";//<--- actualizar con la contraseña de su base de datos 
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public ClsLogicaProd buscarProducto(string codigo)
        {   //Este metodo recibe un string como paramentro
            //Creamos un metodo de tipo producto para retornarle un objeto
            try
            {
                ClsLogicaProd productoSeleccionado = new ClsLogicaProd();
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                //El parametro el cual se recibio es el codigo del producto seleccionado
                string cadena = $"Select * From Producto where cod_Prod ='{codigo}'";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                MySqlDataReader registroEmpleado = comando.ExecuteReader();
                while (registroEmpleado.Read())//<-- Mientras tenga filas almacenadas va a continuar dentro del while
                {   //cada una de estas lineas lee un registro de la fila selecionada
                    productoSeleccionado.Codigo_producto_L = registroEmpleado["Cod_Prod"].ToString();
                    productoSeleccionado.Nombre_producto_L = registroEmpleado["Nom_Prod"].ToString();
                    productoSeleccionado.Fecha_vencimiento_producto_L = registroEmpleado["Fecha_Vencimiento"].ToString();
                    productoSeleccionado.Categoria_producto_L = registroEmpleado["Categoria"].ToString();
                    productoSeleccionado.Precio_unitario_producto_L = Convert.ToDouble(registroEmpleado["Precio_Unitario_Prod"].ToString());
                    productoSeleccionado.Stock_producto_L = Convert.ToInt32(registroEmpleado["Stock_Prod"].ToString());
                }
                conexion.Close();
                //Retornamos el objeto con los datos del producto
                return productoSeleccionado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el intento de Conexion" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //esta funcion recibe un objeto de tipo producto y lo llamamos p_producto por "Parametro_Producto"
        public void modificarDatos(ClsDatosProd p_producto)
        {

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string cod_Prod = p_producto.Codigo_producto_D;
                    string nombre_Prod = p_producto.Nombre_producto_D;

                    //21/12/2023
                    string fecha_vencimiento_string = p_producto.Fecha_vencimiento_producto_D;
                    // Reemplazar "a. m." por "am" y "p. m." por "pm"
                    fecha_vencimiento_string = fecha_vencimiento_string.Replace("0:00:00", "12:00:00 a. m.").Replace("0:00:00 a. m.", "12:00:00 p. m.");
                    fecha_vencimiento_string = fecha_vencimiento_string.Replace("a. m.", "am").Replace("p. m.", "pm");
                    //Cambiamos el formato de la fecha para que coincida con la que se debe insertar en un dato tipo DATE en MySQL
                    DateTime fecha_vencimiento_Prod = DateTime.ParseExact(fecha_vencimiento_string, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    string categoria_Prod = p_producto.Categoria_producto_D;
                    double precio_U_Prod = p_producto.Precio_unitario_producto_D;
                    int stock_Prod = p_producto.Stock_producto_D;

                    string fecha_Formateada_Prod = fecha_vencimiento_Prod.ToString("yyyy-MM-dd HH:mm:ss");

                    //Utilizamos consultas parametrizadas para no concatenar y evitar ataques de inyección SQL
                    string cadena = "UPDATE producto SET Nom_Prod = @nombre, Fecha_Vencimiento = @fecha, Categoria = @categoria, Precio_Unitario_Prod = @precio, Stock_Prod = @stock WHERE Cod_Prod = @codigo";

                    MySqlCommand comando = new MySqlCommand(cadena, conexion);
                    //utilizamos AddWithValue para asociar valores con parámetros en consultas SQL
                    //es decir que les damos un nuevo valor en la consulta con estos comandos 
                    comando.Parameters.AddWithValue("@nombre", nombre_Prod);
                    comando.Parameters.AddWithValue("@fecha", fecha_Formateada_Prod);
                    comando.Parameters.AddWithValue("@categoria", categoria_Prod);
                    comando.Parameters.AddWithValue("@precio", precio_U_Prod);
                    comando.Parameters.AddWithValue("@stock", stock_Prod);
                    comando.Parameters.AddWithValue("@codigo", cod_Prod);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    //Si la modificacion funciono entonces el valor de las filas modificadas sera 1
                    //Por lo tanto se modifico exitosamente
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros para actualizar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo un error en el intento de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void cargar_en_Sql(ClsDatosProd productoD)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string cod_Prod = productoD.Codigo_producto_D;
                    string nombre_Prod = productoD.Nombre_producto_D;
                    string fecha_vencimiento_string = productoD.Fecha_vencimiento_producto_D;

                    // Reemplazar "a. m." por "am" y "p. m." por "pm"
                    fecha_vencimiento_string = fecha_vencimiento_string.Replace("0:00:00", "12:00:00 a. m.").Replace("0:00:00 a. m.", "12:00:00 p. m.");
                    fecha_vencimiento_string = fecha_vencimiento_string.Replace("a. m.", "am").Replace("p. m.", "pm");

                    //Cambiamos el formato de la fecha para que coincida con la que se debe insertar en un dato tipo DATE en MySQL
                    DateTime fecha_vencimiento_Prod = DateTime.ParseExact(fecha_vencimiento_string, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string categoria_Prod = productoD.Categoria_producto_D;
                    double precio_U_Prod = productoD.Precio_unitario_producto_D;
                    int stock_Prod = productoD.Stock_producto_D;

                    string fecha_Formateada_Prod = fecha_vencimiento_Prod.ToString("yyyy-MM-dd");

                    //Utilizamos consultas parametrizadas para no concatenar y evitar ataques de inyección SQL
                    string cadena = "INSERT INTO Producto(Cod_Prod, Fecha_Vencimiento, Stock_Prod, Nom_Prod, Precio_Unitario_Prod, Categoria) " +
                                    "VALUES(@codigo, @fecha, @stock, @nombre, @precio, @categoria)";

                    MySqlCommand comando = new MySqlCommand(cadena, conexion);
                    //utilizamos AddWithValue para asociar valores con parámetros en consultas SQL
                    //es decir que les damos un nuevo valor en la consulta con estos comandos 
                    comando.Parameters.AddWithValue("@codigo", cod_Prod);
                    comando.Parameters.AddWithValue("@fecha", fecha_Formateada_Prod);
                    comando.Parameters.AddWithValue("@nombre", nombre_Prod);
                    comando.Parameters.AddWithValue("@stock", stock_Prod);
                    comando.Parameters.AddWithValue("@precio", precio_U_Prod);
                    comando.Parameters.AddWithValue("@categoria", categoria_Prod);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    //Si la modificación funcionó, entonces el valor de las filas modificadas será 1
                    //Por lo tanto, se modificó exitosamente
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Se registró exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo un error en el intento de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public DataTable tabla_producto()
        {//Creamos una funcion de tipo tabla
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string cadena = "Select * From producto";
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

        public void eliminarProd(ClsDatosProd ProductoDp)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string id = ProductoDp.Codigo_producto_D;
                    string cadena = $"DELETE FROM producto WHERE Cod_Prod = @id";
                    MySqlCommand comando = new MySqlCommand(cadena, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo un error en el intento de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
