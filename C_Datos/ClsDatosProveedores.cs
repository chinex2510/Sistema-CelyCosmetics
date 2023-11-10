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
    internal class ClsDatosProveedores
    {
        private string cuit_D;
        private string empresa_D;
        private string direccion_D;
        private string preventista_D;
        private string email_D;
        private string telefono_D;

        public string Cuit_D { get => cuit_D; set => cuit_D = value; }
        public string Empresa_D { get => empresa_D; set => empresa_D = value; }
        public string Direccion_D { get => direccion_D; set => direccion_D = value; }
        public string Email_D { get => email_D; set => email_D = value; }
        public string Telefono_D { get => telefono_D; set => telefono_D = value; }
        public string Preventista_D { get => preventista_D; set => preventista_D = value; }

        static string servidor = "127.0.0.1";
        static string bd = "celycosmetic";
        static string usuario = "root";
        static string password = "12345";//<--- actualizar con la contraseña de su base de datos 
        static string puerto = "3306";

        string Mysqlconect = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public void cargar_en_Sql(ClsDatosProveedores proveedorD)
        {
            try
            {

                MySqlConnection conexion = new MySqlConnection(Mysqlconect);
                conexion.Open();
                string cuit = proveedorD.Cuit_D;
                string empresa = proveedorD.Empresa_D;
                string direccion = proveedorD.Direccion_D;
                string preventista = proveedorD.Preventista_D;
                string email = proveedorD.Email_D;
                string telefono = proveedorD.Telefono_D;
                string cadena = "INSERT INTO Proveedor(ID_Proveedor,Empresa_Prov, Direccion_Prov,Preventista_Prov, Mail_Prov,Telefono_Prov)" +
                    "VALUES('" + cuit + "','" + empresa + "','" + direccion + "','" + preventista + "','" + email + "','" + telefono + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Proveedor registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el intento de Conexion" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void EliminarProveedor(ClsDatosProveedores proveedorD)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(Mysqlconect);
                conexion.Open();
                string cuit = proveedorD.Cuit_D;
                string empresa = proveedorD.Empresa_D;
                string direccion = proveedorD.Direccion_D;
                string preventista = proveedorD.Preventista_D;
                string email = proveedorD.Email_D;
                string telefono = proveedorD.Telefono_D;
                string cadena = "DELETE FROM Proveedor WHERE ID_Proveedor = @cuit";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@cuit", cuit);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proovedor Eliminado con éxito","Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Hubo un error en el intento de Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void modificarDatos(ClsDatosProveedores p_proveedor)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(Mysqlconect))
                {
                    conexion.Open();
                    string cuit = p_proveedor.Cuit_D;
                    string empresa = p_proveedor.Empresa_D;
                    string direccion = p_proveedor.Direccion_D;
                    string preventista = p_proveedor.Preventista_D;
                    string email = p_proveedor.Email_D;
                    string telefono = p_proveedor.Telefono_D;

                    string cadena = "UPDATE proveedor SET Empresa_Prov = @empresa, Direccion_Prov = @direccion, Preventista_Prov = @preventista, Mail_Prov = @email, Telefono_Prov = @telefono WHERE ID_Proveedor = @cuit";

                    using (MySqlCommand comando = new MySqlCommand(cadena, conexion))
                    {
                        comando.Parameters.AddWithValue("@empresa", empresa);
                        comando.Parameters.AddWithValue("@direccion", direccion);
                        comando.Parameters.AddWithValue("@preventista", preventista);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@cuit", cuit);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registro de proveedor modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el intento de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ClsLogicaProveedores selectorEmpleado(string cuit)
        {
            try
            {
                ClsLogicaProveedores proveedorSeleccionado = new ClsLogicaProveedores();
                MySqlConnection conexion = new MySqlConnection(Mysqlconect);

                string cadena = $"Select * From Proveedor where ID_Proveedor ={cuit}";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                MySqlDataReader registroProveedor = comando.ExecuteReader();
                while (registroProveedor.Read())
                {
                    proveedorSeleccionado.Cuit_L = registroProveedor["ID_Proveedor"].ToString();
                    proveedorSeleccionado.Empresa_L = registroProveedor["Empresa_Prov"].ToString();
                    proveedorSeleccionado.Direccion_L = registroProveedor["Direccion_Prov"].ToString();
                    proveedorSeleccionado.Preventista_L = registroProveedor["Preventista_Prov"].ToString();
                    proveedorSeleccionado.Email_L = registroProveedor["Mail_Prov"].ToString();
                    proveedorSeleccionado.Telefono_L = registroProveedor["Telefono_Prov"].ToString();
                }

                conexion.Close();
                return proveedorSeleccionado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el intento de Conexion" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable tabla_prov()
        {


            //Creamos una funcion de tipo tabla
            try
            {
                MySqlConnection conexion = new MySqlConnection(Mysqlconect);
                conexion.Open();
                string cadena = "Select * From proveedor";
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
