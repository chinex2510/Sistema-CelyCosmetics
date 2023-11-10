using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using Proyecto3.C_Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.C_Datos
{
    internal class ClsDatosDevoluciones
    {
        static string servidor = "127.0.0.1";
        static string bd = "celycosmetic";
        static string usuario = "root";
        static string password = "12345";//<--- actualizar con la contraseña de su base de datos 
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        private string codProd_D;
        private int stock_D;
        private int num_Recibo_D;

        public string CodProd_D { get => codProd_D; set => codProd_D = value; }
        public int Stock_D { get => stock_D; set => stock_D = value; }
        public int Num_Recibo_D { get => num_Recibo_D; set => num_Recibo_D = value; }

        public DataTable tabla_venta_selecionada(int num_recibo)
        {
            //Creamos una funcion de tipo tabla
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string cadena = "SELECT     p.Nom_Prod AS Producto,    dr.Cantidad_Vendida AS Cantidad," +
                    "    dr.Subtotal AS Importe,    dr.Cod_Prod AS Cod_Prod FROM Detalle_Recibo dr " +
                    $"JOIN Producto p ON dr.Cod_Prod = p.Cod_Prod WHERE dr.Recibo_Venta_Numero = {num_recibo};";
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


        public void modificarDatos(ClsDatosDevoluciones p_producto)
        {

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string cod_Prod = p_producto.CodProd_D;

                    // Obtener el stock actual del producto desde la base de datos
                    string selectQuery = "SELECT Stock_Prod FROM producto WHERE Cod_Prod = @codigo";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, conexion);
                    selectCommand.Parameters.AddWithValue("@codigo", cod_Prod);
                    int stockActual = (int)selectCommand.ExecuteScalar();

                    // Sumar la cantidad deseada al stock actual
                    int cantidadASumar = p_producto.Stock_D;
                    int nuevoStock = stockActual + cantidadASumar;
                    int numero_Recibo = p_producto.Num_Recibo_D;

                    // Utilizar una consulta parametrizada para actualizar el stock
                    string updateQuery = "UPDATE producto SET Stock_Prod = @nuevoStock WHERE Cod_Prod = @codigo";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, conexion);
                    updateCommand.Parameters.AddWithValue("@nuevoStock", nuevoStock);
                    updateCommand.Parameters.AddWithValue("@codigo", cod_Prod);
                    int filasAfectadas = updateCommand.ExecuteNonQuery();

                    // Insertar los datos en la tabla devoluciones
                    string insertDevo = "INSERT INTO devoluciones (Cantidad_Devuelta, Recibo_Venta_Num, Cod_Prod) " +
                        "VALUES (@cantidad, @numeroVenta, @codigo)";
                    MySqlCommand insertCommand = new MySqlCommand(insertDevo, conexion);
                    insertCommand.Parameters.AddWithValue("@numeroVenta", numero_Recibo);
                    insertCommand.Parameters.AddWithValue("@codigo", cod_Prod);
                    insertCommand.Parameters.AddWithValue("@cantidad", p_producto.Stock_D);
                    int filasAfectadas2 = insertCommand.ExecuteNonQuery();

                    // Obtener la cantidad actual de Cantidad_Vendida
                    string selectDetalle = "SELECT Cantidad_Vendida FROM Detalle_Recibo" +
                        " WHERE Recibo_Venta_Numero = @numRecibo AND Cod_Prod = @codProd;";
                    MySqlCommand cantidadCommand = new MySqlCommand(selectDetalle, conexion);
                    cantidadCommand.Parameters.AddWithValue("@numRecibo", numero_Recibo);
                    cantidadCommand.Parameters.AddWithValue("@codProd", cod_Prod);
                    int cantidadActual = (int)cantidadCommand.ExecuteScalar();

                    int cantidadARestar = p_producto.Stock_D;
                    int nuevaCantidad = cantidadActual - cantidadARestar;
                    //--------------------------------------------------------------------------------------------------------
                    string obtenerPrecio_U = "SELECT Precio_Unitario_Prod FROM producto Where Cod_Prod = @codProd";
                    MySqlCommand precio_u_Command = new MySqlCommand(obtenerPrecio_U, conexion);
                    precio_u_Command.Parameters.AddWithValue("@codProd", cod_Prod);
                    float Precio_Unitario = Convert.ToSingle(precio_u_Command.ExecuteScalar());




                    string obtenerTotalRecibo = "SELECT Total_Recibo " +
                        "FROM Recibo_Venta where Recibo_Venta_Numero= @numerorecibo;";
                    MySqlCommand obterner_total_Command = new MySqlCommand(obtenerTotalRecibo, conexion);
                    obterner_total_Command.Parameters.AddWithValue("@numerorecibo", numero_Recibo);
                    float total_Recibo = Convert.ToSingle(obterner_total_Command.ExecuteScalar());
                    MessageBox.Show($"Total del Recibo: {total_Recibo} , PrecioUnitario: {Precio_Unitario} , SeMultiplicaPor: {p_producto.Stock_D}");
                    MessageBox.Show($"{total_Recibo - (Precio_Unitario * Convert.ToSingle(p_producto.Stock_D))}");

                    double NuevoValorDetalleRecivo = total_Recibo - (Precio_Unitario * Convert.ToSingle(p_producto.Stock_D));
                    MessageBox.Show($"{NuevoValorDetalleRecivo}");
                    //--------------------------------------------------------------------------------------------------------
                    //Actualizar el valor de la venta
                    string actualizaimporte = $"update recibo_venta set Total_Recibo = @NuevoTotal where Recibo_Venta_Numero = {numero_Recibo};";
                    MySqlCommand TotalCommand = new MySqlCommand(actualizaimporte, conexion);
                    TotalCommand.Parameters.AddWithValue("@NuevoTotal", NuevoValorDetalleRecivo);
                    TotalCommand.ExecuteNonQuery();

                    // Actualizar la cantidad vendida en Detalle_Recibo
                    string updateDetalle = "UPDATE Detalle_Recibo SET Cantidad_Vendida = @StockDescontado" +
                        " WHERE Recibo_Venta_Numero = @numRecibo AND Cod_Prod = @codProd;";
                    MySqlCommand detalleCommand = new MySqlCommand(updateDetalle, conexion);
                    detalleCommand.Parameters.AddWithValue("@numRecibo", numero_Recibo);
                    detalleCommand.Parameters.AddWithValue("@codProd", cod_Prod);
                    detalleCommand.Parameters.AddWithValue("@StockDescontado", nuevaCantidad);
                    int filasAfectadas3 = detalleCommand.ExecuteNonQuery();

                    // Verificar si las modificaciones fueron exitosas
                    if (filasAfectadas > 0 && filasAfectadas2 > 0 && filasAfectadas3 > 0)
                    {
                        MessageBox.Show("El proceso se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros para actualizar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Se produjo un error en el intento de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

