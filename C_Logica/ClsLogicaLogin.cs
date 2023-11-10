using Proyecto3.C_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3.C_Logica
{
    internal class ClsLogicaLogin
    {
        public bool logeo(string usuario, string contraseña)
        {
            ClsDatosLogin validarD = new ClsDatosLogin();
            bool valid = validarD.Validacion(usuario, contraseña);
            return valid;
        }
    }
}
