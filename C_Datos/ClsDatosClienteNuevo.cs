using MySql.Data.MySqlClient;
using Proyecto3.C_Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.C_Datos
{
    internal class ClsDatosClienteNuevo
    {
        private int dni_D;
        private string nombre_D;
        private string apellido_D;
        private string telefono_D;
        private string email_D;
        private string direccion_D;

        public int Dni_D { get => dni_D; set => dni_D = value; }
        public string Nombre_D { get => nombre_D; set => nombre_D = value; }
        public string Apellido_D { get => apellido_D; set => apellido_D = value; }
        public string Telefono_D { get => telefono_D; set => telefono_D = value; }
        public string Email_D { get => email_D; set => email_D = value; }
        public string Direccion_D { get => direccion_D; set => direccion_D = value; }

        static string servidor = "127.0.0.1";
        static string bd = "celycosmetic";
        static string usuario = "root";
        static string password = "12345";//<--- actualizar con la contraseña de su base de datos 
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public void cargar_en_Sql(ClsDatosClienteNuevo clienteN)
        {
            try//<-- try: se utiliza para intentar conectarse a la base de datos si no se conecta, no entra al try
            {   //va por el "catch"

                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                //Abrimos la conexion y guardamos dentro de variables locale
                //Los datos del objeto de ta capa logica
                int dni = clienteN.dni_D;
                string nombre = clienteN.nombre_D;
                string apellido = clienteN.apellido_D;
                string telefono = clienteN.telefono_D;
                string email = clienteN.email_D;
                string direccion = clienteN.direccion_D;

                //Creamos una variable En la cual almacenamos una texto el cual en este caso es el 
                //comando SQL para Insertar un nuevo Cliente
                string cadena = "INSERT INTO cliente(Cliente_DNI,Nombre_Cli,Apellido_Cli,Telefono_Cli,Mail_Cli,Direccion_Cli)" +
                    "VALUES('" + dni + "','" + nombre + "','" + apellido + "','" + telefono + "','" + email + "','" + direccion + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);//<--Envia el comando y la conexion
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha registrado exitosamente al nuevo cliente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {//si la conexion no es exitosa :
                MessageBox.Show("Hubo un error en el intento de Conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// El catch es una función que se utiliza para identificar errores en código, al intentar ejecutar cierto código,
             // en el caso de ocurrir un error, se ejecuta el catch, el cual ejecutará una excepción que nos avisará del error,
             // pudiendo así identificar con más facilidad el lugar donde ocurrió.
        }

        public DataTable tabla_nuevocliente()
        {//Creamos una funcion de tipo tabla
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string cadena = "Select * From cliente";
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
                MessageBox.Show("Hubo un error en el intento de Conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public ClsLogicaClienteNuevo selectorNuevoCliente(int dni)
        {   //Este metodo recibe un entero como paramentro
            //Creamos un metodo de tipo empleado para retornarle un objeto ... Cliente_DNI
            try
            {
                ClsLogicaClienteNuevo clienteSelecionado = new ClsLogicaClienteNuevo();
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                //El parametro el cual se recibio es el id del empleado seleccionado
                string cadena = $"Select * From cliente where Cliente_DNI ={dni}";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                MySqlDataReader registroNuevoCliente = comando.ExecuteReader();
                while (registroNuevoCliente.Read())//<-- Mientras tenga filas almacenadas va a continuar dentro del while
                {   //cada una de estas lineas lee un registro de la fila selecionada
                    clienteSelecionado.Dni = Convert.ToInt32(registroNuevoCliente["Cliente_DNI"].ToString());
                    clienteSelecionado.Nombre = registroNuevoCliente["Nombre_Cli"].ToString();
                    clienteSelecionado.Apellido = registroNuevoCliente["Apellido_Cli"].ToString();
                    clienteSelecionado.Telefono = registroNuevoCliente["Telefono_Cli"].ToString();
                    clienteSelecionado.Email = registroNuevoCliente["Mail_Cli"].ToString();
                    clienteSelecionado.Direccion = registroNuevoCliente["Direccion_Cli"].ToString();
                }
                conexion.Close();
                return clienteSelecionado;
            }
            catch
            {
                MessageBox.Show("Hubo un error en el intento de Conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public void modificarDatos(ClsDatosClienteNuevo p_cliente)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                int dni = p_cliente.Dni_D;
                string nombre = p_cliente.Nombre_D;
                string apellido = p_cliente.Apellido_D;
                string telefono = p_cliente.Telefono_D;
                string email = p_cliente.Email_D;
                string direccion = p_cliente.Direccion_D;

                string cadena = "UPDATE cliente SET Nombre_Cli ='" + nombre + "', Apellido_Cli ='" + apellido +
                    "',Telefono_Cli ='" + telefono + "',Mail_Cli ='" + email +
                    "',Direccion_Cli ='" + direccion + "' WHERE Cliente_DNI =" + dni + " ";

                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el intento de Conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void eliminarNuevoCliente(ClsDatosClienteNuevo NuevoClienteDp)

        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                int dni = NuevoClienteDp.dni_D;
                string nombre = NuevoClienteDp.nombre_D;
                string apellido = NuevoClienteDp.apellido_D;
                string telefono = NuevoClienteDp.telefono_D;
                string email = NuevoClienteDp.email_D;
                string direccion = NuevoClienteDp.direccion_D;

                string cadena = $"delete from cliente where Cliente_DNI = {dni}";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente Eliminado Exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Hubo un error en el intento de Conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable busquedaNuevoCliente(int dni)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string cadena = $"Select * From cliente where Cliente_DNI = {dni}";
                MySqlDataReader leer_filasSQL; //MySqlDataReader <-- Lee un flujo de filas unicamente de SQL
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


        public DataTable tabla_cli()
        {
            
            //Creamos una funcion de tipo tabla
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string cadena = "Select * From Cliente";
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
