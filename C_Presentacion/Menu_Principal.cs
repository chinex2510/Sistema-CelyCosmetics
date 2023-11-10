using Proyecto3.C_Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form factura = new Factura();
            factura.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form prod = new Form_CRUD_Prod();
            prod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form prov = new Form_CRUD_Prov();
            prov.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Usuario = new Form2();
            Usuario.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form cerrarSesion = new Fnt_Login();
            cerrarSesion.Show();
            this.Close();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Form cliente = new Form_CRUD_Cliente_Nuevo();
            cliente.Show();
            this.Hide();
        }

        private void btn_HistorialVentas_Click(object sender, EventArgs e)
        {
            Form historyV = new FrmRegistroVentas();
            historyV.Show();
            this.Hide();
        }
    }
}
