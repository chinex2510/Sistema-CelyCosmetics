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
    public partial class Factura : Form
    {
        /*-----------Variables---------------*/
        private string codigo;
        private double cont;
        private double precioEliminar;
        private string codigoProducto1;
        private int i;
        private int contador;
        private int clienteDni = 0;
        private int bandera = 0;
        private int imprimir = 0;
        private int ticketImp = 0;
        private double total_Fac = 0;
        private int Producto_Cantidad;
        private double descuentoFac;
        /*-----------------------------------*/

        public Factura()
        {
            InitializeComponent();
        }



        private void EventoEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (!String.IsNullOrEmpty(txtCodProd_KeyPress.Text))
                {
                    ClsLogicaFactura oproducto = new ClsLogicaFactura();
                    ClsLogicaFactura oproducto1 = new ClsLogicaFactura();
                    oproducto1 = oproducto.selectProd(txtCodProd_KeyPress.Text);
                    if (oproducto1.Producto != null)
                    {
                        txtCodProd_KeyPress.Text = oproducto1.Codprod.ToString();
                        Producto_Cantidad = oproducto1.Cantidad;
                        lblProd.Text = oproducto1.Producto.ToString();
                        lblPrecio.Text = oproducto1.Precio.ToString();
                        codigo = txtCodProd_KeyPress.Text;
                        bandera = 1;

                        txtCodProd_KeyPress.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Producto Inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodProd_KeyPress.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Debes agregar un producto primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera = 0;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvLista.SelectedRows[0];

                // Obtiene el precio de la fila seleccionada
                double precioEliminar = Convert.ToDouble(filaSeleccionada.Cells[4].Value);

                // Borra la fila del DataGridView
                dgvLista.Rows.Remove(filaSeleccionada);

                // Resta el precio del producto eliminado del subtotal
                cont -= precioEliminar;
                total_Fac -= precioEliminar;


                // Actualiza el valor de lblSubTotal
                txtDescuento.Text = $"0";
                lblTotal_Factura.Text = total_Fac.ToString();
                lblSubTotal.Text = cont.ToString();
                ticketImp -= 1;
            }
            else
            {
                MessageBox.Show("Selecciona una fila para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Control nuevoControl = txtCodProd_KeyPress;
            nuevoControl.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblTotal_Factura.Text))
            {
                imprimir = 1;
                imprimirTicket();
            }
            else
            {
                MessageBox.Show("Primero debes completar el campo");
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            double descuento;

            if (!String.IsNullOrEmpty(txtDescuento.Text))
            {
                descuento = Convert.ToInt32(txtDescuento.Text);
                descuentoFac = descuento;
                descuento = (cont * descuento) / 100;
                total_Fac = (cont - descuento);
                lblTotal_Factura.Text = $"{Math.Round(total_Fac, 2)}";
            }

        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCliente.Text))
                {
                    ClsLogicaFactura ocliente = new ClsLogicaFactura();
                    ClsLogicaFactura ocliente1 = ocliente.selectCliente(txtCliente.Text);
                    if (ocliente1.Dni != 0)
                    {
                        txtCliente.Text = ocliente1.Dni.ToString();
                        clienteDni = Convert.ToInt32(txtCliente.Text);
                        MessageBox.Show("Cliente Encontrado. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Control nuevoControl = txtCodProd_KeyPress;
                        nuevoControl.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Cliente inexistente. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCliente.Text = "0";
                        Control nuevoControl = txtCodProd_KeyPress;
                        nuevoControl.Focus();
                    }
                }
            }
        }

        private void refresh()
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Mostrar la fecha actual en el Label
            lblFecha.Text = "Fecha : " + fechaActual.ToString("dd/MM/yyyy");
            lblNumeroTicket.Text = $"{0}";
            ClsLogicaFactura odatosFac = new ClsLogicaFactura();
            ClsLogicaFactura odatosFac1 = odatosFac.numFac(Convert.ToInt32(lblNumeroTicket.Text));
            contador = 0;
            contador = 1 + (Convert.ToInt32(odatosFac1.NumFactura.ToString()));
            lblNumeroTicket.Text = $"Recibo Numero: {contador}";
            txtDescuento.Text = "";
            lblSubTotal.Text = "0";
            lblTotal_Factura.Text = "0";
            txtCliente.Text = "";
            dgvLista.Rows.Clear();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescuento.Text))
            {
                ClsLogicaFactura oempleado = new ClsLogicaFactura();
                int numticket; // El número de factura debe ser el mismo para todos los productos
                if (int.TryParse(contador.ToString(), out numticket))
                {
                    ClsLogicaFactura reciboVenta = guardarRecibo();
                    oempleado.GuardarRecibo(reciboVenta);
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        if (row.Cells["CodigoProducto"].Value != null) // Asegúrate de que haya un producto en la fila
                        {
                            ClsLogicaFactura ventaProducto = guardarVenta(row, numticket);
                            oempleado.guardar(ventaProducto);
                        }
                    }
                    if (imprimir == 1)
                    {
                        imprimir = 0;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea imprimir el ticket antes de vender?", "Confirmación", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            imprimirTicket();
                        }
                        else
                        {
                            refresh();
                        }
                    }
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Primero debe agregar un descuento. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private ClsLogicaFactura guardarVenta(DataGridViewRow row, int numticket)
        {
            ClsLogicaFactura oventarealizada = new ClsLogicaFactura();

            oventarealizada.Precio = Convert.ToDouble(row.Cells["PrecioProducto"].Value);
            oventarealizada.NumFactura = numticket;
            oventarealizada.Subtotal = Convert.ToDouble(row.Cells["TotalProducto"].Value);
            oventarealizada.Cantidad = Convert.ToInt32(row.Cells["CantidadProducto"].Value);
            oventarealizada.Codprod = Convert.ToString(row.Cells["CodigoProducto"].Value);

            return oventarealizada;
        }

        private ClsLogicaFactura guardarRecibo()
        {
            ClsLogicaFactura oventarealizada = new ClsLogicaFactura();

            oventarealizada.Dni = clienteDni;
            oventarealizada.Descuento = Convert.ToDouble(txtDescuento.Text);
            oventarealizada.PrecioTotal = Convert.ToDouble(lblTotal_Factura.Text);

            return oventarealizada;
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se hace clic en el encabezado de columna
            {
                // Obtén la fila que se hizo clic
                DataGridViewRow selectedRow = dgvLista.Rows[e.RowIndex];

                // Accede a los valores de las celdas de esa fila
                double precio = Convert.ToDouble(selectedRow.Cells["TotalProducto"].Value.ToString());
                precioEliminar = Convert.ToInt32(precio);
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Form menu = new Menu_Principal();
            menu.Show();
            this.Hide();
        }

        private void Factura_Load_1(object sender, EventArgs e)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Mostrar la fecha actual en el Label
            lblFecha.Text = "Fecha : " + fechaActual.ToString("dd/MM/yyyy");
            lblNumeroTicket.Text = $"{0}";
            ClsLogicaFactura odatosFac = new ClsLogicaFactura();
            ClsLogicaFactura odatosFac1 = odatosFac.numFac(Convert.ToInt32(lblNumeroTicket.Text));
            contador = 0;
            contador = 1 + (Convert.ToInt32(odatosFac1.NumFactura.ToString()));
            lblNumeroTicket.Text = $"Recibo Numero: {contador}";
            txtDescuento.Text = "";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int cantidad;
            string producto;
            double precio;
            double total;
            if (bandera == 1)
            {
                // Obtener los datos en el evento EventoEnter
                ClsLogicaFactura oproducto = new ClsLogicaFactura();
                ClsLogicaFactura oproducto1 = oproducto.selectProd(txtCodProd_KeyPress.Text);
                cantidad = Convert.ToInt32(txtCantidad.Text);
                producto = lblProd.Text;
                precio = Convert.ToDouble(lblPrecio.Text);
                total = cantidad * precio;

                if (cantidad <= Producto_Cantidad)
                {
                    // Agregar los datos al DataGridView

                    DataGridViewRow fila = new DataGridViewRow();
                    i = 0;
                    fila.CreateCells(dgvLista); // dataGridView1 es el nombre de tu DataGridView
                    fila.Cells[0].Value = codigo;
                    fila.Cells[1].Value = producto;
                    fila.Cells[2].Value = precio;
                    fila.Cells[3].Value = cantidad;
                    fila.Cells[4].Value = total;
                    int cantidadFilas = dgvLista.RowCount;
                    codigoProducto1 = producto;
                    dgvLista.Rows.Add(fila);
                    ticketImp += 1;
                    Control nuevoControl = txtCodProd_KeyPress;
                    nuevoControl.Focus();

                    // Limpiar el TextBox después de agregar los datos
                    txtCodProd_KeyPress.Text = "";
                    lblProd.Text = "-";
                    lblPrecio.Text = "-";
                    txtCantidad.Text = "1";

                    cont = 0;

                    // Calcular el subtotal sumando los totales de todas las filas en el DataGridView
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        if (row.Cells[4].Value != null)
                        {
                            cont += Convert.ToDouble(row.Cells[4].Value);
                        }
                    }

                    // Actualizar el valor de lblSubTotal
                    total_Fac += total;
                    lblTotal_Factura.Text = total_Fac.ToString();
                    lblSubTotal.Text = cont.ToString();
                    bandera = 0;
                }
                else
                {
                    MessageBox.Show("Stock Disponible: " + Producto_Cantidad, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Primero escanea un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void imprimirTicket()
        {
            double subtotal;
            double total;
            int descuento;
            if (ticketImp > 0 && !String.IsNullOrEmpty(txtDescuento.Text))
            {
                //Creamos una instancia d ela clase CrearTicket
                ClsCrearTicketVenta ticket = new ClsCrearTicketVenta();
                //Ya podemos usar todos sus metodos
                ticket.AbreCajon();//Para abrir el cajon de dinero.

                //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

                //Datos de la cabecera del Ticket.
                ticket.TextoCentro("CELY COSMETICS");
                ticket.TextoIzquierda("ENALTAMOS TU BELLEZA");
                ticket.TextoIzquierda("DIREC: DIRECCION DE LA EMPRESA");
                ticket.TextoIzquierda("TELEF: 4530000");//CAMBIAR
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("Caja # 1", "Ticket #" + lblNumeroTicket.Text);

                ticket.lineasAsteriscos();

                //Sub cabecera.
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("ATENDIÓ: Celina");
                ticket.TextoIzquierda("CLIENTE: " + txtCliente.Text);
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
                ticket.lineasAsteriscos();

                //Articulos a vender.
                ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                ticket.lineasAsteriscos();
                //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
                foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
                {
                    ticket.AgregaArticulo(fila.Cells[1].Value.ToString(), int.Parse(fila.Cells[3].Value.ToString()),
                    double.Parse(fila.Cells[2].Value.ToString()), double.Parse(fila.Cells[4].Value.ToString()));
                }
                ticket.lineasIgual();

                //Resumen de la venta. Sólo son ejemplos
                double.TryParse(lblSubTotal.Text, out subtotal);
                double.TryParse(lblTotal_Factura.Text, out total);
                int.TryParse(txtDescuento.Text, out descuento);
                ticket.AgregarTotales("         SUBTOTAL......$", +subtotal);
                ticket.AgregarTotales($"         DESCUENTO......$", +descuento);
                ticket.AgregarTotales("         TOTAL.........$", +total);
                ticket.TextoIzquierda("");
                //ticket.AgregarTotales("         EFECTIVO......$", decimal.Parse(txtEfectivo_Factura.Text));
                //ticket.AgregarTotales("         CAMBIO........$", decimal.Parse(lblDevolucion_Factura.Text));

                //Texto final del Ticket.
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: " + txtCantidad.Value);
                ticket.TextoIzquierda("");
                ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
                ticket.CortaTicket();
                ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera  
            }
            else
            {
                MessageBox.Show("No puedes imprimir un ticket sin terminar de completar los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
