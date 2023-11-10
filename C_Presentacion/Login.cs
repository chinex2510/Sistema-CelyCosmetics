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

namespace Proyecto3
{
    public partial class Fnt_Login : Form
    {
        public Fnt_Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar su Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Debe ingresar una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ClsLogicaLogin Verificar = new ClsLogicaLogin();
                    bool valid = Verificar.logeo(txtUsuario.Text, txtPassword.Text);
                    if (valid == true)
                    {
                        Form menu = new Menu_Principal();
                        menu.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
            txtPassword.Focus();
        }
    }
}
