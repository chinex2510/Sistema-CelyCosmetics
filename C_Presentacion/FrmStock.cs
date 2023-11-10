using Proyecto3.C_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.C_Presentacion
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

       

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            ClsLogicaProveedores objProveedor = new ClsLogicaProveedores();
            dgv_Stock.DataSource = objProveedor.mostrar_tabla();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            ClsLogicaProd objProducto = new ClsLogicaProd();
            dgv_Stock.DataSource = objProducto.mostrar_tabla();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            ClsLogicaProd objProducto = new ClsLogicaProd();
            dgv_Stock.DataSource = objProducto.mostrar_tabla();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form produc = new Form_CRUD_Prod();
            produc.Show();
            this.Hide();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            ClsLogicaClienteNuevo objProveedor = new ClsLogicaClienteNuevo();
            dgv_Stock.DataSource = objProveedor.mostrar_tabla();
        }
    }
}
