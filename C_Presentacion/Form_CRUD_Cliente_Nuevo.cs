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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto3.C_Presentacion
{
    public partial class Form_CRUD_Cliente_Nuevo : Form
    {
        public Form_CRUD_Cliente_Nuevo()
        {
            InitializeComponent();
        }
        private ClsLogicaClienteNuevo guardarNuevoCliente()
        {
            ClsLogicaClienteNuevo onuevocliente = new ClsLogicaClienteNuevo();
            onuevocliente.Dni = Convert.ToInt32(txtDNINuevoCliente.Text);
            onuevocliente.Nombre = txtNombreNuevoCliente.Text;
            onuevocliente.Apellido = txtApellidoNuevoCliente.Text;
            onuevocliente.Telefono = txtTelefonoNuevoCliente.Text;
            onuevocliente.Email = txtMailNuevoCliente.Text;
            onuevocliente.Direccion = txtDirreccionNuevoCliente.Text;

            return onuevocliente;
        }

        private ClsLogicaClienteNuevo pasarClogica()
        {
            ClsLogicaClienteNuevo onuevocliente = new ClsLogicaClienteNuevo();
            onuevocliente.Dni = Convert.ToInt32(txtDNINuevoCliente.Text);
            onuevocliente.Nombre = txtNombreNuevoCliente.Text;
            onuevocliente.Apellido = txtApellidoNuevoCliente.Text;
            onuevocliente.Telefono = txtTelefonoNuevoCliente.Text;
            onuevocliente.Email = txtMailNuevoCliente.Text;
            onuevocliente.Direccion = txtDirreccionNuevoCliente.Text;

            return onuevocliente;
        }

        private void btnBuscarNuevoCliente_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtDNINuevoCliente.Text))
            {

                ClsLogicaClienteNuevo onuevocliente = new ClsLogicaClienteNuevo();
                ClsLogicaClienteNuevo onuevocliente2 = new ClsLogicaClienteNuevo();
                onuevocliente2 = onuevocliente.SelectClient(Convert.ToInt32(txtDNINuevoCliente.Text));
                if (Convert.ToInt32(onuevocliente2.Dni.ToString()) > 0)
                {
                    txtDNINuevoCliente.Enabled = false;
                    txtDNINuevoCliente.Text = onuevocliente2.Dni.ToString();

                }
                else
                {
                    txtDNINuevoCliente.Enabled = true;
                    txtDNINuevoCliente.Text = "";
                    MessageBox.Show("No se ha encontrado al cliente", "ERROR", MessageBoxButtons.OK);
                }

                txtNombreNuevoCliente.Text = onuevocliente2.Nombre;
                txtApellidoNuevoCliente.Text = onuevocliente2.Apellido;
                txtTelefonoNuevoCliente.Text = onuevocliente2.Telefono;
                txtMailNuevoCliente.Text = onuevocliente2.Email;
                txtDirreccionNuevoCliente.Text = onuevocliente2.Direccion;

            }
            else 
            {
               MessageBox.Show("Debe ingresar el DNI del cliente para poder buscarlo", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnLimpiarNuevoCliente_Click(object sender, EventArgs e)
        {
            txtDNINuevoCliente.Enabled = true;
            txtDNINuevoCliente.Text = "";
            txtNombreNuevoCliente.Text = "";
            txtApellidoNuevoCliente.Text = "";
            txtTelefonoNuevoCliente.Text = "";
            txtMailNuevoCliente.Text = "";
            txtDirreccionNuevoCliente.Text = "";
        }

        private void btnModificarNuevoCliente_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtDNINuevoCliente.Text))
            {
                if (!String.IsNullOrEmpty(txtNombreNuevoCliente.Text))
                {
                    if (!String.IsNullOrEmpty(txtApellidoNuevoCliente.Text))
                    {
                        if (!String.IsNullOrEmpty(txtTelefonoNuevoCliente.Text))
                        {
                            if (!String.IsNullOrEmpty(txtMailNuevoCliente.Text))
                            {

                                ClsLogicaClienteNuevo nuevocliente = new ClsLogicaClienteNuevo();
                                nuevocliente.CargarMod(pasarClogica());
                                pasarClogica();
                                txtDNINuevoCliente.Enabled = true;
                                txtDNINuevoCliente.Text = "";
                                txtNombreNuevoCliente.Text = "";
                                txtApellidoNuevoCliente.Text = "";
                                txtTelefonoNuevoCliente.Text = "";
                                txtMailNuevoCliente.Text = "";
                                txtDirreccionNuevoCliente.Text = "";

                            }
                            else
                            {
                                MessageBox.Show("Debe haber un Email del cliente para guardar los cambios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Debe haber un Telefono del cliente para guardar los cambios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Debe haber un Apellido del cliente para guardar los cambios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber un Nombre del cliente para guardar los cambios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Debe haber un DNI del cliente para guardar los cambios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminarNuevoCliente_Click(object sender, EventArgs e)
        {
            ClsLogicaClienteNuevo oNuevoCliente = new ClsLogicaClienteNuevo();
            oNuevoCliente.EliminarClienteNuevo(pasarClogica());
            pasarClogica();
        }

        private void btnGuardarNuevoCliente_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtDNINuevoCliente.Text))
            {
                if (!String.IsNullOrEmpty(txtNombreNuevoCliente.Text))
                {
                    if (!String.IsNullOrEmpty(txtApellidoNuevoCliente.Text))
                    {
                        if (!String.IsNullOrEmpty(txtTelefonoNuevoCliente.Text))
                        {
                            if (!String.IsNullOrEmpty(txtMailNuevoCliente.Text))
                            {

                                ClsLogicaClienteNuevo oempleado = new ClsLogicaClienteNuevo();
                                oempleado.guardar(guardarNuevoCliente());
                                guardarNuevoCliente();
                                txtDNINuevoCliente.Text = "";
                                txtNombreNuevoCliente.Text = "";
                                txtApellidoNuevoCliente.Text = "";
                                txtTelefonoNuevoCliente.Text = "";
                                txtMailNuevoCliente.Text = "";
                                txtDirreccionNuevoCliente.Text = "";

                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar el Email del cliente para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar el Telefono del cliente para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el Apellido del cliente para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el Nombre del cliente para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Debe ingresar el DNI del cliente para Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelarNuevoCliente_Click(object sender, EventArgs e)
        {
            Form historialventa = new FrmRegistroVentas();
            historialventa.Show();
            this.Hide();
        }

        private void txtDNINuevoCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombreNuevoCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellidoNuevoCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDirreccionNuevoCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefonoNuevoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMailNuevoCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMailNuevoCliente_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
