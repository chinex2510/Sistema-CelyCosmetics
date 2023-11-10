using Proyecto3.C_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3.C_Logica
{
    internal class ClsLogicaClienteNuevo
    {
        private int dni;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private string direccion;

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        //_______________________________________________________________________________________


        public DataTable mostrar_tabla()
        {
            ClsDatosClienteNuevo clienteN = new ClsDatosClienteNuevo();
            DataTable tabla = new DataTable();
            tabla = clienteN.tabla_nuevocliente();
            return tabla;
        }

        public void guardar(ClsLogicaClienteNuevo p_nuevocliente)
        {
            ClsDatosClienteNuevo Clientenc = new ClsDatosClienteNuevo();
            Clientenc.cargar_en_Sql(PasarDatos(p_nuevocliente));
        }

        public ClsLogicaClienteNuevo SelectClient(int dni)
        {
            ClsDatosClienteNuevo clienteN = new ClsDatosClienteNuevo();
            ClsLogicaClienteNuevo ocliente = new ClsLogicaClienteNuevo();
            ocliente = clienteN.selectorNuevoCliente(dni);
            return ocliente;
        }


        public void CargarMod(ClsLogicaClienteNuevo p_nuevocliente)
        {
            ClsDatosClienteNuevo EmpleadoD = new ClsDatosClienteNuevo();
            EmpleadoD.modificarDatos(PasarDatos(p_nuevocliente));
        }

        public ClsDatosClienteNuevo PasarDatos(ClsLogicaClienteNuevo p_nuevocliente)
        {
            ClsDatosClienteNuevo clienteN = new ClsDatosClienteNuevo();
            clienteN.Dni_D = p_nuevocliente.Dni;
            clienteN.Nombre_D = p_nuevocliente.Nombre;
            clienteN.Apellido_D = p_nuevocliente.Apellido;
            clienteN.Telefono_D = p_nuevocliente.Telefono;
            clienteN.Email_D = p_nuevocliente.Email;
            clienteN.Direccion_D = p_nuevocliente.Direccion;

            return clienteN;
        }

        public void EliminarClienteNuevo(ClsLogicaClienteNuevo p_nuevocliente)
        {
            ClsDatosClienteNuevo ClienteN = new ClsDatosClienteNuevo();
            ClienteN.eliminarNuevoCliente(PasarDatos(p_nuevocliente));
        }

        public DataTable mostrarNuevoClienteBuscado(int idp)
        {
            ClsDatosClienteNuevo clienteN = new ClsDatosClienteNuevo();
            DataTable tabla = new DataTable();
            tabla = clienteN.busquedaNuevoCliente(idp);
            return tabla;
        }
    }
}
