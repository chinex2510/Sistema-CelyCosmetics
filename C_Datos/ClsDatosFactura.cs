using MySql.Data.MySqlClient;
using Proyecto3.C_Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.C_Datos
{
    internal class ClsDatosFactura
    {
        static string servidor = "127.0.0.1";
        static string bd = "celycosmetic";
        static string usuario = "root";
        static string password = "12345";//<--- actualizar con la contraseña de su base de datos 
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        private string codprod_D;
        private string producto_D;
        private double precio_D;
        private string fecha_D;
        private int cantidad_D;
        private int dni_D;
        private int numeroFactura_D;
        private double descuento_D;
        private int usuario_id_D;
        private double subtotal_D;
        private double precio_total_D;

        public string Codprod_D { get => codprod_D; set => codprod_D = value; }
        public string Producto_D { get => producto_D; set => producto_D = value; }
        public double Precio_D { get => precio_D; set => precio_D = value; }
        public string Fecha_D { get => fecha_D; set => fecha_D = value; }
        public int Cantidad_D { get => cantidad_D; set => cantidad_D = value; }
        public int Dni_D { get => dni_D; set => dni_D = value; }
        public int NumeroFactura_D { get => numeroFactura_D; set => numeroFactura_D = value; }
        public double Descuento_D { get => descuento_D; set => descuento_D = value; }
        public int Usuario_id_D { get => usuario_id_D; set => usuario_id_D = value; }
        public double Subtotal_D { get => subtotal_D; set => subtotal_D = value; }
        public double Precio_total_D { get => precio_total_D; set => precio_total_D = value; }

        public ClsLogicaFactura MostrarProducto(string codigo)
        {
            try
            {
                ClsLogicaFactura producto = new ClsLogicaFactura();
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                //El parametro el cual se recibio es el codigo del producto seleccionado
                string cadena = $"Select * From producto WHERE Cod_Prod ='{codigo}'";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                MySqlDataReader leerProducto = comando.ExecuteReader();
                while (leerProducto.Read())//<-- Mientras tenga filas almacenadas va a continuar dentro del while
                {   //cada una de estas lineas lee un registro de la fila selecionada
                    producto.Codprod = leerProducto["Cod_Prod"].ToString();
                    producto.Producto = leerProducto["Nom_Prod"].ToString();
                    producto.Precio = Convert.ToDouble(leerProducto["Precio_Unitario_Prod"].ToString());
                    producto.Cantidad = Convert.ToInt32(leerProducto["Stock_Prod"].ToString());
                }
                conexion.Close();
                //Retornamos el objeto con los datos del producto
                return producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public ClsLogicaFactura SeleccionarCliente(string dni)
        {
            try
            {
                ClsLogicaFactura cliente = new ClsLogicaFactura();
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                //El parametro el cual se recibio es el codigo del producto seleccionado
                string cadena = $"Select * From Cliente WHERE Cliente_DNI ='{dni}'";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                MySqlDataReader leerCliente = comando.ExecuteReader();
                while (leerCliente.Read())//<-- Mientras tenga filas almacenadas va a continuar dentro del while
                {   //cada una de estas lineas lee un registro de la fila selecionada
                    cliente.Dni = Convert.ToInt32(leerCliente["Cliente_DNI"].ToString());
                }
                conexion.Close();
                //Retornamos el objeto con los datos del producto
                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public ClsLogicaFactura mostrarNum(int num)
        {
            try
            {
                ClsLogicaFactura count = new ClsLogicaFactura();
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                string query = "SELECT COUNT(*) FROM recibo_venta";

                MySqlCommand comando = new MySqlCommand(query, conexion);

                count.NumFactura = Convert.ToInt32(comando.ExecuteScalar());

                conexion.Close();

                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        public void InsertarReciboVenta(ClsDatosFactura ventaN)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                int dni = ventaN.dni_D;
                double descuento = ventaN.descuento_D;
                double precioTotal = ventaN.precio_total_D;


                string query1 = "INSERT INTO recibo_venta (Usuario_ID, Cliente_DNI, Descuento_Recibo, Total_Recibo) VALUES (@usuarioID, @clienteDNI, @descuento, @total)";
                MySqlCommand comando1 = new MySqlCommand(query1, conexion);
                comando1.Parameters.AddWithValue("@usuarioID", 1); // Esto debería ser dinámico dependiendo del usuario actual
                comando1.Parameters.AddWithValue("@clienteDNI", dni); // Asegúrate de obtener este valor de forma segura
                comando1.Parameters.AddWithValue("@descuento", descuento); // Asegúrate de obtener este valor de forma segura
                comando1.Parameters.AddWithValue("@total", precioTotal); // Asegúrate de obtener este valor de forma segura
                int filasafectadas = comando1.ExecuteNonQuery();
                if (filasafectadas > 0)
                {
                    MessageBox.Show("Venta Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo realizar la venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en recibo_venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertarDetalleRecibo(ClsDatosFactura ventaN, int numeroFactura)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            string codprod = ventaN.codprod_D;
            double subtotal = ventaN.subtotal_D;
            int cantidad = ventaN.cantidad_D;
            try
            {
                string query2 = "INSERT INTO detalle_recibo (Cantidad_Vendida, Subtotal, Cod_Prod, Recibo_Venta_Numero) VALUES (@cantidad, @subtotal, @codProd, @numFactura)";
                MySqlCommand comando2 = new MySqlCommand(query2, conexion);
                comando2.Parameters.AddWithValue("@cantidad", cantidad); // Asegúrate de obtener este valor de forma segura
                comando2.Parameters.AddWithValue("@subtotal", subtotal); // Asegúrate de obtener este valor de forma segura
                comando2.Parameters.AddWithValue("@codProd", codprod); // Asegúrate de obtener este valor de forma segura
                comando2.Parameters.AddWithValue("@numFactura", numeroFactura); // Asegúrate de obtener este valor de forma segura
                int filasafectadas = comando2.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en detalle_recibo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void actualizarStockVenta(ClsDatosFactura ventaN, int numeroFactura)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string codprod = ventaN.codprod_D;
                double subtotal = ventaN.subtotal_D;
                int cantidad = ventaN.cantidad_D;
                // Obtener el stock actual del producto desde la base de datos
                string selectQuery = "SELECT Stock_Prod FROM producto WHERE Cod_Prod = @codigo";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conexion);
                selectCommand.Parameters.AddWithValue("@codigo", codprod);
                int stockActual = (int)selectCommand.ExecuteScalar();

                // Sumar la cantidad deseada al stock actual
                int cantidadaRestar = ventaN.cantidad_D;
                int nuevoStock = stockActual - cantidadaRestar;
                int numero_Recibo = numeroFactura;

                // Utilizar una consulta parametrizada para actualizar el stock
                string updateQuery = "UPDATE producto SET Stock_Prod = @nuevoStock WHERE Cod_Prod = @codigo";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, conexion);
                updateCommand.Parameters.AddWithValue("@nuevoStock", nuevoStock);
                updateCommand.Parameters.AddWithValue("@codigo", codprod);
                updateCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en detalle_recibo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
