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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private ClsLogicaUsuario pasarClogica()
        {
            ClsLogicaUsuario ousuario = new ClsLogicaUsuario();
            ousuario.Nombre = txtNombre.Text;
            ousuario.Apellido = txtApellido.Text;
            ousuario.Telefono = txtTelefono.Text;
            ousuario.Email = txtEmail.Text;
            ousuario.Contrasenia = txtContrasenia.Text;
            ousuario.Direccion = txtDireccion.Text;
            return ousuario;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ClsLogicaUsuario ousuario = new ClsLogicaUsuario();
            ClsLogicaUsuario ousuario1 = new ClsLogicaUsuario();
            ousuario1 = ousuario.SelectUsuario(txtUsuario.Text);
            txtUsuario.Text = ousuario1.Usuario_iD.ToString();
            txtContrasenia.Text = ousuario1.Contrasenia;
            txtNombre.Text = ousuario1.Nombre;
            txtApellido.Text = ousuario1.Apellido;
            txtEmail.Text = ousuario1.Email;
            txtDireccion.Text = ousuario1.Direccion;
            txtTelefono.Text = ousuario1.Telefono;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {     
            if (!String.IsNullOrEmpty(txtUsuario.Text))
            {
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    if (!String.IsNullOrEmpty(txtContrasenia.Text))
                    {
                        if (!String.IsNullOrEmpty(txtApellido.Text))
                        {
                            if (!String.IsNullOrEmpty(txtEmail.Text))
                            {
                                if (!String.IsNullOrEmpty(txtDireccion.Text))
                                {
                                    if (!String.IsNullOrEmpty(txtTelefono.Text))
                                    {
                                        ClsLogicaUsuario usuario = new ClsLogicaUsuario();
                                        usuario.CargarMod(pasarClogica());
                                        pasarClogica();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe registrar su telefono para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }   
                                }
                                else
                                {
                                        MessageBox.Show("Debe registrar la dirrección para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                            else
                            {
                              MessageBox.Show("Debe registrar su e-mail para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                                MessageBox.Show("Debe registrar su apellido para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    { 
                      MessageBox.Show("Debe registrar la contraseña para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
                else 
                {
                  MessageBox.Show("Debe registrar su nombre para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Debe registrar el ID usuario para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_Principal();
            menu.Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
