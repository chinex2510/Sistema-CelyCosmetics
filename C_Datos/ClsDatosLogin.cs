using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.C_Datos
{
    internal class ClsDatosLogin
    {
            static string servidor = "127.0.0.1";
            static string bd = "celycosmetic";
            static string usuario = "root";
            static string password = "12345";//<--- actualizar con la contraseña de su base de datos 
            static string puerto = "3306";

            string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

            public bool Validacion(string Usuario_p, string Contraseña_p)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                    conexion.Open();
                    string cadena = $"Select * From Usuario where Usuario_ID = 1";
                    MySqlCommand comando = new MySqlCommand(cadena, conexion);
                    MySqlDataReader registroUsuario = comando.ExecuteReader();
                    while (registroUsuario.Read())
                    {
                        if (Usuario_p == registroUsuario["Mail_Usu"].ToString() && Contraseña_p == registroUsuario["Contrasenia_Usu"].ToString())
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("El Usuario o la Contraseña son incorrectos", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    conexion.Close();
                    return false;
                }
                catch
                {

                    MessageBox.Show("Hubo un error en el intento de Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }