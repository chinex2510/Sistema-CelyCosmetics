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
    public partial class Frm_Devoluciones : Form
    {
        private int _idRecibo;
        private double _totalRecibo;
        private string _codProd;
        private int _cantidad;
        public Frm_Devoluciones(int idRecibo)
        {
            InitializeComponent();
            _idRecibo = idRecibo;
        }
       

        private void Frm_Devoluciones_Load(object sender, EventArgs e)
        {
            double sumaImportes = 0;
            ClsLogicaDevoluciones objVenta = new ClsLogicaDevoluciones();
            DataTable dataTable = objVenta.mostrar_busqueda(_idRecibo);/*
            dataTable.Columns["Cod_Prod"].ColumnMapping = MappingType.Hidden; // Oculta la columna Cod_Prod*/
            dgv_Detalle_Recibo.DataSource = dataTable;

            foreach (DataGridViewRow row in dgv_Detalle_Recibo.Rows)
            {
                if (row.Cells["Importe"].Value != null && double.TryParse(row.Cells["Importe"].Value.ToString(), out double importe))
                {
                    sumaImportes += importe;
                }
            }
            _totalRecibo += sumaImportes;
            lbl_Valor_Total.Text = _totalRecibo.ToString();
        }

        private void dgv_Detalle_Recibo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se hace clic en el encabezado de columna
            {
                // Obtén la fila que se hizo clic
                DataGridViewRow selectedRow = dgv_Detalle_Recibo.Rows[e.RowIndex];

                // Accede a los valores de las celdas de esa fila
                string codigo_Prod = selectedRow.Cells["Cod_Prod"].Value.ToString();
                string Producto = selectedRow.Cells["Producto"].Value.ToString();
                string articulos = selectedRow.Cells["Cantidad"].Value.ToString();
                string importe = selectedRow.Cells["Importe"].Value.ToString();


                // Haz lo que necesites con estos valores

                _codProd = codigo_Prod;
                _cantidad = Convert.ToInt32(articulos);
            }
        }
        private void btn_Devolucion_Click(object sender, EventArgs e)
        {

            if (_idRecibo != 0)
            {
                if (_cantidad > 0)
                {
                    Form cantidad = new FrmCantidadDevolver(_codProd, _cantidad, _idRecibo);
                    cantidad.Show();
                }
                else
                {
                    MessageBox.Show($"El producto seleccionado tiene una venta de 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Para poder devolver un producto debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form historial_venta = new FrmRegistroVentas();
            historial_venta.Show();
            this.Hide();
        }
    }
}
