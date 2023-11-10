using Proyecto3.C_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3.C_Logica
{
    internal class ClsLogicaUsuario
    {

        private int usuario_iD;
        private string nombre;
        private string apellido;
        private string contrasenia;
        private string email;
        private string direccion;
        private string telefono;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Usuario_iD { get => usuario_iD; set => usuario_iD = value; }

        public ClsLogicaUsuario SelectUsuario(string cod)
        {
            ClsDatosUsuario usuarioD = new ClsDatosUsuario();
            ClsLogicaUsuario ousuario = new ClsLogicaUsuario();
            ousuario = usuarioD.MostrarUsuario(cod);
            return ousuario;
        }

        public void CargarMod(ClsLogicaUsuario p_usuario)
        {
            ClsDatosUsuario UsuarioD = new ClsDatosUsuario();
            UsuarioD.modificarDatos(PasarDatos(p_usuario));
        }

        public ClsDatosUsuario PasarDatos(ClsLogicaUsuario p_Usuario)
        {
            ClsDatosUsuario usuarioD = new ClsDatosUsuario();
            usuarioD.Nombre_D = p_Usuario.Nombre;
            usuarioD.Apellido_D = p_Usuario.Apellido;
            usuarioD.Telefono_D = p_Usuario.Telefono;
            usuarioD.Email_D = p_Usuario.Email;
            usuarioD.Contrasenia_D = p_Usuario.Contrasenia;
            usuarioD.Direccion_D = p_Usuario.Direccion;
            return usuarioD;
        }
    }
}
