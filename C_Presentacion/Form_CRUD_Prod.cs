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
    public partial class Form_CRUD_Prod : Form
    {
        public Form_CRUD_Prod()
        {
            InitializeComponent();
        }

        //Una funcion con la cual hacemos una copia de datos y lo pasamos a la capa logica 
        private ClsLogicaProd pasarClogica()
        {
            string fechaOriginal = txt_Fecha_Vencimiento.Text;

            if (DateTime.TryParseExact(fechaOriginal, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
            {

                string fechaFormateada = fecha.ToString("dd/MM/yyyy");

                ClsLogicaProd oproducto = new ClsLogicaProd();
                oproducto.Codigo_producto_L = txt_Cod_Prod.Text;
                oproducto.Nombre_producto_L = txt_Nombre_Prod.Text;
                oproducto.Fecha_vencimiento_producto_L = fechaFormateada;
                oproducto.Categoria_producto_L = txt_Categoria.Text;
                oproducto.Precio_unitario_producto_L = Convert.ToDouble(txt_Precio_Unitario.Text);
                oproducto.Stock_producto_L = Convert.ToInt32(txt_Stock.Text);
                return oproducto;

            }
            else
            {
                ClsLogicaProd oproducto = new ClsLogicaProd();
                oproducto.Codigo_producto_L = txt_Cod_Prod.Text;
                oproducto.Nombre_producto_L = txt_Nombre_Prod.Text;
                oproducto.Fecha_vencimiento_producto_L = txt_Fecha_Vencimiento.Text;
                oproducto.Categoria_producto_L = txt_Categoria.Text;
                oproducto.Precio_unitario_producto_L = Convert.ToDouble(txt_Precio_Unitario.Text);
                oproducto.Stock_producto_L = Convert.ToInt32(txt_Stock.Text);
                return oproducto;
            }

        }


            private void Form_CRUD_Prod_Load(object sender, EventArgs e)
            {

            }

            private void btn_Buscar_Click(object sender, EventArgs e)
            {
                if (String.IsNullOrEmpty(txt_Cod_Prod.Text))
                {
                    txt_Cod_Prod.Focus();
                    txt_Cod_Prod.Enabled = true;
                    txt_Cod_Prod.Text = "";
                    txt_Nombre_Prod.Text = "";
                    txt_Fecha_Vencimiento.Text = "";
                    txt_Categoria.Text = "";
                    txt_Precio_Unitario.Text = "";
                    txt_Stock.Text = "";
                }
                else
                {
                    ClsLogicaProd oproducto = new ClsLogicaProd();
                    ClsLogicaProd oproducto1 = new ClsLogicaProd();
                    oproducto1 = oproducto.SelectProducto(txt_Cod_Prod.Text);
                    txt_Cod_Prod.Enabled = false;
                    txt_Cod_Prod.Text = oproducto1.Codigo_producto_L;
                    txt_Nombre_Prod.Text = oproducto1.Nombre_producto_L;
                    txt_Fecha_Vencimiento.Text = oproducto1.Fecha_vencimiento_producto_L;
                    txt_Categoria.Text = oproducto1.Categoria_producto_L;
                    txt_Precio_Unitario.Text = oproducto1.Precio_unitario_producto_L.ToString();
                    txt_Stock.Text = oproducto1.Stock_producto_L.ToString();
                }
            }

            private void btn_Limpiar_Click(object sender, EventArgs e)
            {
                txt_Cod_Prod.Enabled = true;
                txt_Cod_Prod.Text = "";
                txt_Fecha_Vencimiento.Text = "";
                txt_Nombre_Prod.Text = "";
                txt_Categoria.Text = "";
                txt_Precio_Unitario.Text = "";
                txt_Stock.Text = "";
            }

            private void btn_Modificar_Click(object sender, EventArgs e)
            {
            if (!String.IsNullOrEmpty(txt_Cod_Prod.Text))
            {
                if (!String.IsNullOrEmpty(txt_Fecha_Vencimiento.Text))
                {
                    if (!String.IsNullOrEmpty(txt_Categoria.Text))
                    {
                        if (!String.IsNullOrEmpty(txt_Stock.Text))
                        {
                            if (!String.IsNullOrEmpty(txt_Precio_Unitario.Text))
                            {
                                if (!String.IsNullOrEmpty(txt_Nombre_Prod.Text))
                                {
                                    ClsLogicaProd empleado = new ClsLogicaProd();
                                    empleado.CargarMod(pasarClogica());
                                    pasarClogica();
                                    txt_Cod_Prod.Enabled = true;
                                    txt_Cod_Prod.Text = "";
                                    txt_Fecha_Vencimiento.Text = "";
                                    txt_Nombre_Prod.Text = "";
                                    txt_Categoria.Text = "";
                                    txt_Precio_Unitario.Text = "";
                                    txt_Stock.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("El nombre de producto no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_Nombre_Prod.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El precio Unitario no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_Precio_Unitario.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El stock no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Stock.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La categoria no puede estar vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Categoria.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La fecha de vencimiento no puede estar vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Fecha_Vencimiento.Focus();
                }
            }
            else
            {
                MessageBox.Show("El Codigo de Producto no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cod_Prod.Focus();
            }

            
            }

            private void btn_Guardar_Click(object sender, EventArgs e)
            {

            if (!String.IsNullOrEmpty(txt_Cod_Prod.Text))
            {
                if (!String.IsNullOrEmpty(txt_Fecha_Vencimiento.Text))
                {
                    if (!String.IsNullOrEmpty(txt_Categoria.Text))
                    {
                        if (!String.IsNullOrEmpty(txt_Stock.Text))
                        {
                            if (!String.IsNullOrEmpty(txt_Precio_Unitario.Text))
                            {
                                if (!String.IsNullOrEmpty(txt_Nombre_Prod.Text))
                                {
                                    ClsLogicaProd oempleado = new ClsLogicaProd();
                                    oempleado.guardar(pasarClogica());
                                    pasarClogica();
                                    txt_Cod_Prod.Text = "";
                                    txt_Fecha_Vencimiento.Text = "";
                                    txt_Nombre_Prod.Text = "";
                                    txt_Categoria.Text = "";
                                    txt_Precio_Unitario.Text = "";
                                    txt_Stock.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("El nombre de producto no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_Nombre_Prod.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El precio Unitario no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_Precio_Unitario.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El stock no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Stock.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La categoria no puede estar vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Categoria.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La fecha de vencimiento no puede estar vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Fecha_Vencimiento.Focus();
                }
            }
            else
            {
                MessageBox.Show("El Codigo de Producto no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cod_Prod.Focus();
            }

           
            }

            private void btn_Eliminar_Click(object sender, EventArgs e)
            {

            if (!String.IsNullOrEmpty(txt_Cod_Prod.Text))
            {
                ClsLogicaProd oProducto = new ClsLogicaProd();
                oProducto.EliminarProducto(pasarClogica());
                pasarClogica();
                txt_Cod_Prod.Enabled = true;
                txt_Cod_Prod.Text = "";
                txt_Fecha_Vencimiento.Text = "";
                txt_Nombre_Prod.Text = "";
                txt_Categoria.Text = "";
                txt_Precio_Unitario.Text = "";
                txt_Stock.Text = "";
            }
            else
            {
                MessageBox.Show("Para eliminar un producto el Codigo de Producto no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cod_Prod.Focus();
            }

            }

            private void btn_Cancelar_Click(object sender, EventArgs e)
            {
                Form menu = new Menu_Principal();
                menu.Show();
                this.Hide();
            }

            private void btn_VerStock_Click(object sender, EventArgs e)
            {
                Form stock = new FrmStock();
                stock.Show();
                this.Hide();
            }

        private void txt_Cod_Prod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Fecha_Vencimiento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Stock_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Nombre_Prod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Precio_Unitario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Categoria_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    } 
