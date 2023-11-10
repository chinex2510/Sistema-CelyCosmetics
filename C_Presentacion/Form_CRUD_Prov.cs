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
using Proyecto3.C_Datos;

namespace Proyecto3.C_Presentacion
{
    public partial class Form_CRUD_Prov : Form
    {
        public Form_CRUD_Prov()
        {
            InitializeComponent();
        }


        private ClsLogicaProveedores guardarProveedor()
        {
            ClsLogicaProveedores oproveedor = new ClsLogicaProveedores();
            oproveedor.Cuit_L = txt_Cuit_Prov.Text;
            oproveedor.Empresa_L = txt_Empresa_Prov.Text;
            oproveedor.Direccion_L = txt_Direccion_Prov.Text;
            oproveedor.Preventista_L = txt_Preventista_Prov.Text;
            oproveedor.Email_L = txt_Email_Prov.Text;
            oproveedor.Telefono_L = txt_Telefono_Prov.Text;

            return oproveedor;
        }

        private ClsLogicaProveedores pasarLogica() {
            
            ClsLogicaProveedores oproveedor = new ClsLogicaProveedores();
            oproveedor.Cuit_L = txt_Cuit_Prov.Text;
            oproveedor.Empresa_L = txt_Empresa_Prov.Text;
            oproveedor.Direccion_L = txt_Direccion_Prov.Text;
            oproveedor.Preventista_L = txt_Preventista_Prov.Text;
            oproveedor.Email_L = txt_Email_Prov.Text;
            oproveedor.Telefono_L = txt_Telefono_Prov.Text;

            return oproveedor;

        }

        private void Form_CRUD_Prov_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Prov_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Cuit_Prov.Text))
            {
                MessageBox.Show("Debe ingresar su CUIT ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (String.IsNullOrEmpty(txt_Empresa_Prov.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de su Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (String.IsNullOrEmpty(txt_Direccion_Prov.Text))
                    {
                        MessageBox.Show("Debe ingresar su direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(txt_Email_Prov.Text))
                        {
                            MessageBox.Show("Debe ingresar su email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            if (String.IsNullOrEmpty(txt_Telefono_Prov.Text))
                            {
                                MessageBox.Show("Debe ingresar su numero de telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                ClsLogicaProveedores prov = new ClsLogicaProveedores();
                                prov.guardar(guardarProveedor());
                                guardarProveedor();
                            }
                        }
                    }
                }
            }
        }

        private void btn_Buscar_Prov_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Cuit_Prov.Text))
            {
                MessageBox.Show("Debe ingresar el CUIT del proveedor para buscarlo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Cuit_Prov.Focus();
                txt_Cuit_Prov.Enabled = true;
                txt_Cuit_Prov.Text = "";
                txt_Empresa_Prov.Text = "";
                txt_Direccion_Prov.Text = "";
                txt_Preventista_Prov.Text = "";
                txt_Email_Prov.Text = "";
                txt_Telefono_Prov.Text = "";
            }
            else
            {

                ClsLogicaProveedores oproveedor = new ClsLogicaProveedores();
                oproveedor = oproveedor.SelectEmpleado(txt_Cuit_Prov.Text);

                txt_Cuit_Prov.Enabled = false;
                txt_Cuit_Prov.Text = oproveedor.Cuit_L;
                txt_Empresa_Prov.Text = oproveedor.Empresa_L;
                txt_Direccion_Prov.Text = oproveedor.Direccion_L;
                txt_Preventista_Prov.Text = oproveedor.Preventista_L;
                txt_Email_Prov.Text = oproveedor.Email_L;
                txt_Telefono_Prov.Text = oproveedor.Telefono_L;


            }
        }

        private void btn_Limpiar_Prov_Click_1(object sender, EventArgs e)
        {
            txt_Cuit_Prov.Enabled = true;
            txt_Cuit_Prov.Text = "";
            txt_Empresa_Prov.Text = "";
            txt_Direccion_Prov.Text = "";
            txt_Preventista_Prov.Text = "";
            txt_Email_Prov.Text = "";
            txt_Telefono_Prov.Text = "";
        }

        private void btn_Cancelar_Prov_Click_1(object sender, EventArgs e)
        {
            Form menu = new Menu_Principal();
            menu.Show();
            this.Hide();
        }

        private void btn_Modificar_Prov_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Cuit_Prov.Text))
            {
                MessageBox.Show("Debe ingresar el CUIT para poder modificar el Proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (String.IsNullOrEmpty(txt_Empresa_Prov.Text))
                {
                    MessageBox.Show("El nombre de su Empresa no puede estar vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (String.IsNullOrEmpty(txt_Direccion_Prov.Text))
                    {
                        MessageBox.Show("La direccion de su Empresa no puede estar vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(txt_Email_Prov.Text))
                        {
                            MessageBox.Show("Su email no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            if (String.IsNullOrEmpty(txt_Telefono_Prov.Text))
                            {
                                MessageBox.Show("Numero de telefono no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                ClsLogicaProveedores mproveedor = new ClsLogicaProveedores();
                                mproveedor.CargarMod(guardarProveedor());
                                guardarProveedor();
                                txt_Cuit_Prov.Enabled = true;
                                txt_Empresa_Prov.Text = "";
                                txt_Direccion_Prov.Text = "";
                                txt_Preventista_Prov.Text = "";
                                txt_Email_Prov.Text = "";
                                txt_Telefono_Prov.Text = "";
                            }
                        }
                    }
                }
            }

        }

        private void btn_Eliminar_Prov_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_Cuit_Prov.Text))
            {
                MessageBox.Show("Debe ingresar el CUIT para poder eliminar el Proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClsLogicaProveedores oproveedor = new ClsLogicaProveedores();
                oproveedor.EliminarProveedor(pasarLogica());
                pasarLogica();
            }
        }

        private void txt_Cuit_Prov_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Empresa_Prov_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Direccion_Prov_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Preventista_Prov_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Email_Prov_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Telefono_Prov_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
