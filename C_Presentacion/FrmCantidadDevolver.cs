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
    public partial class FrmCantidadDevolver : Form
    {
        private string _cod_Prod;
        private int _cantidad;
        private int _id_recibo;

        public FrmCantidadDevolver(string cod_prod, int cantidad, int id_recibo)
        {
            InitializeComponent();
            _cod_Prod = cod_prod;
            _cantidad = cantidad;
            _id_recibo = id_recibo;
        }
        private ClsLogicaDevoluciones pasarClogica()
        {
            ClsLogicaDevoluciones oproducto = new ClsLogicaDevoluciones();
            oproducto.CodProd_L = _cod_Prod;
            oproducto.Stock_L = Convert.ToInt32(txt_Cantidad.Value);
            oproducto.Num_Recibo_L = _id_recibo;
            return oproducto;
        }
        

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            ClsLogicaDevoluciones empleado = new ClsLogicaDevoluciones();
            empleado.CargarMod(pasarClogica());
            pasarClogica();
        }

        private void FrmCantidadDevolver_Load_1(object sender, EventArgs e)
        {
            txt_Cantidad.Minimum = 0;
            txt_Cantidad.Maximum = _cantidad;
            txt_Cantidad.Value = txt_Cantidad.Maximum;
        }

        private void txt_Cantidad_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form Registro = new Frm_Devoluciones(_id_recibo);
            Registro.Show();
            this.Hide();
        }
    }
}
