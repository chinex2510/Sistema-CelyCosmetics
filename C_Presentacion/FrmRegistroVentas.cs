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
    public partial class FrmRegistroVentas : Form
    {
        public FrmRegistroVentas()
        {
            InitializeComponent();
        }
        private int id_recibo = 0;
        


        private void txt_Num_Recibo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_Num_Recibo.Text))
            {

                // Verificar si cada carácter es un dígito numérico
                foreach (char c in txt_Num_Recibo.Text)
                {
                    if (!Char.IsDigit(c))
                    {
                        MessageBox.Show("Por favor, ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Num_Recibo.Text = ""; // Limpiar el TextBox si se ingresan caracteres no numéricos
                        return;
                    }
                }

                ClsLogicaVentas objVenta = new ClsLogicaVentas();
                dgvHistorialVenta.DataSource = objVenta.mostrar_busqueda(Convert.ToInt32(txt_Num_Recibo.Text));
            }
            else
            {
                ClsLogicaVentas objVentas = new ClsLogicaVentas();
                dgvHistorialVenta.DataSource = objVentas.mostrar_tabla_venta();

                // Ajustar automáticamente el tamaño de las columnas
                dgvHistorialVenta.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Alinear los datos al centro
                foreach (DataGridViewColumn column in dgvHistorialVenta.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

        }

        private void btn_Detalle_Click(object sender, EventArgs e)
        {
            if (id_recibo != 0)
            {
                Form detalle = new Frm_Devoluciones(id_recibo);
                detalle.Show();
            }
            else
            {
                MessageBox.Show("Para ver el detalle primero debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        

        private void dgvHistorialVenta_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se hace clic en el encabezado de columna
            {
                // Obtén la fila que se hizo clic
                DataGridViewRow selectedRow = dgvHistorialVenta.Rows[e.RowIndex];

                // Accede a los valores de las celdas de esa fila
                string recibo = selectedRow.Cells["Recibo"].Value.ToString();
                string fecha = selectedRow.Cells["Fecha"].Value.ToString();
                string articulos = selectedRow.Cells["Articulos"].Value.ToString();
                string total = selectedRow.Cells["Total"].Value.ToString();
                string dni = selectedRow.Cells["DNI"].Value.ToString();

                if (dgvHistorialVenta.SelectedRows.Count > 0)
                {
                    // Cambia el color del botón cuando se selecciona una fila en el DataGridView
                    btn_Detalle.BackColor = Color.Red;
                }
                else
                {
                    // Restaura el color original del botón cuando no hay ninguna fila seleccionada
                    btn_Detalle.BackColor = DefaultBackColor;
                }
                id_recibo = Convert.ToInt32(recibo);

            }
        }

        private void FrmRegistroVentas_Load_1(object sender, EventArgs e)
        {
            ClsLogicaVentas objVentas = new ClsLogicaVentas();
            dgvHistorialVenta.DataSource = objVentas.mostrar_tabla_venta();

            // Ajustar automáticamente el tamaño de las columnas
            dgvHistorialVenta.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Alinear los datos al centro
            foreach (DataGridViewColumn column in dgvHistorialVenta.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_Principal();
            menu.Show();
            this.Hide();
        }
    }
}
