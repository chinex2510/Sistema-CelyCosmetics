using Proyecto3.C_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3.C_Logica
{
    internal class ClsLogicaProveedores
    {
        private string cuit_L;
        private string empresa_L;
        private string direccion_L;
        private string preventista_L;
        private string email_L;
        private string telefono_L;

        public string Cuit_L { get => cuit_L; set => cuit_L = value; }
        public string Empresa_L { get => empresa_L; set => empresa_L = value; }
        public string Direccion_L { get => direccion_L; set => direccion_L = value; }
        public string Email_L { get => email_L; set => email_L = value; }
        public string Telefono_L { get => telefono_L; set => telefono_L = value; }
        public string Preventista_L { get => preventista_L; set => preventista_L = value; }

        public ClsDatosProveedores PasarDatos(ClsLogicaProveedores p_Proveedor)
        {
            ClsDatosProveedores oproveedor = new ClsDatosProveedores();
            oproveedor.Cuit_D = p_Proveedor.Cuit_L;
            oproveedor.Empresa_D = p_Proveedor.Empresa_L;
            oproveedor.Direccion_D = p_Proveedor.Direccion_L;
            oproveedor.Preventista_D = p_Proveedor.Preventista_L;
            oproveedor.Email_D = p_Proveedor.Email_L;
            oproveedor.Telefono_D = p_Proveedor.Telefono_L;
            return oproveedor;
        }

        public void EliminarProveedor(ClsLogicaProveedores p_proveedor)
        {
            ClsDatosProveedores proveedor_D = new ClsDatosProveedores();
            proveedor_D.EliminarProveedor(PasarDatos(p_proveedor));
        }

     

        public void guardar(ClsLogicaProveedores p_proveedor)
        {
            ClsDatosProveedores oproveedor = new ClsDatosProveedores();
            oproveedor.cargar_en_Sql(PasarDatos(p_proveedor));
        }

        public void CargarMod(ClsLogicaProveedores p_proveedor)
        {
            ClsDatosProveedores mproveedor = new ClsDatosProveedores();
            mproveedor.modificarDatos(PasarDatos(p_proveedor));

        }

        public ClsLogicaProveedores SelectEmpleado(string cuit)
        {
            ClsDatosProveedores proveedorD = new ClsDatosProveedores();
            ClsLogicaProveedores oproveedor = new ClsLogicaProveedores();
            oproveedor = proveedorD.selectorEmpleado(cuit);
            return oproveedor;
        }

        public DataTable mostrar_tabla()
        {
            ClsDatosProveedores productoD = new ClsDatosProveedores();
            DataTable tabla = new DataTable();
            tabla = productoD.tabla_prov();
            return tabla;
        }

    }
}
