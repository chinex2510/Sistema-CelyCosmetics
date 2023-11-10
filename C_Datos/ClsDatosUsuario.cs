using MySql.Data.MySqlClient;
using Proyecto3.C_Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.C_Datos
{
    internal class ClsDatosUsuario
    {
        static string servidor = "127.0.0.1";
        static string bd = "celycosmetic";
        static string usuario = "root";
        static string password = "12345";//<--- actualizar con la contraseña de su base de datos 
        static string puerto = "3306";

        string connectionString = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        private int usuarioID_D;
        private string nombre_D;
        private string apellido_D;
        private string contrasenia_D;
        private string email_D;
        private string direccion_D;
        private string telefono_D;

        public string Nombre_D { get => nombre_D; set => nombre_D = value; }
        public string Apellido_D { get => apellido_D; set => apellido_D = value; }
        public string Contrasenia_D { get => contrasenia_D; set => contrasenia_D = value; }
        public string Email_D { get => email_D; set => email_D = value; }
        public string Direccion_D { get => direccion_D; set => direccion_D = value; }
        public string Telefono_D { get => telefono_D; set => telefono_D = value; }
        public int UsuarioID_D { get => usuarioID_D; set => usuarioID_D = value; }

        public ClsLogicaUsuario MostrarUsuario(string codigo)
        {   //Este metodo recibe un string como paramentro
            //Creamos un metodo de tipo producto para retornarle un objeto
            try
            {
                ClsLogicaUsuario usuario = new ClsLogicaUsuario();
                MySqlConnection conexion = new MySqlConnection(connectionString);
                //El parametro el cual se recibio es el codigo del producto seleccionado
                string cadena = "Select * From Usuario where Usuario_ID ='1'";
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                MySqlDataReader leerUsuario = comando.ExecuteReader();
                while (leerUsuario.Read())//<-- Mientras tenga filas almacenadas va a continuar dentro del while
                {   //cada una de estas lineas lee un registro de la fila selecionada
                    usuario.Usuario_iD = Convert.ToInt32(leerUsuario["Usuario_ID"]);
                    usuario.Nombre = leerUsuario["Nombre_Usu"].ToString();
                    usuario.Apellido = leerUsuario["Apellido_Usu"].ToString();
                    usuario.Contrasenia = leerUsuario["Contrasenia_Usu"].ToString();
                    usuario.Email = leerUsuario["Mail_Usu"].ToString();
                    usuario.Direccion = leerUsuario["Direccion_Usu"].ToString();
                    usuario.Telefono = leerUsuario["Telefono_Usu"].ToString();
                }
                conexion.Close();
                //Retornamos el objeto con los datos del producto
                return usuario;
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error en el intento de Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void modificarDatos(ClsDatosUsuario p_usuario)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    string contrasenia = p_usuario.Contrasenia_D;
                    string nombre = p_usuario.Nombre_D;
                    string apellido = p_usuario.Apellido_D;
                    string telefono = p_usuario.Telefono_D;
                    string email = p_usuario.Email_D;
                    string direccion = p_usuario.Direccion_D;

                    string cadena = "UPDATE usuario SET Nombre_Usu = @nombre, Apellido_Usu = @apellido, Telefono_Usu = @telefono, Mail_Usu = @email, Contrasenia_Usu = @contrasenia, Direccion_Usu = @direccion WHERE Usuario_ID = 1";

                    using (MySqlCommand comando = new MySqlCommand(cadena, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@apellido", apellido);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@contrasenia", contrasenia);
                        comando.Parameters.AddWithValue("@direccion", direccion);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registro modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un error en la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
