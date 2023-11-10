namespace Proyecto3.C_Presentacion
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDireccion1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.labelEfectivo = new System.Windows.Forms.Label();
            this.lblNumeroTicket = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCodProd_KeyPress = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labelDevolucion = new System.Windows.Forms.Label();
            this.lblTotal_Factura = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(295, 460);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(99, 47);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(408, -41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(228, 34);
            this.label14.TabIndex = 27;
            this.label14.Text = "Factura Cosmetics";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVender.Location = new System.Drawing.Point(143, 460);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(100, 47);
            this.btnVender.TabIndex = 26;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblDireccion1);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.labelEfectivo);
            this.panel1.Controls.Add(this.lblNumeroTicket);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.txtCodProd_KeyPress);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.labelDevolucion);
            this.panel1.Controls.Add(this.lblTotal_Factura);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.lblProd);
            this.panel1.Controls.Add(this.labelCantidad);
            this.panel1.Controls.Add(this.labelProducto);
            this.panel1.Controls.Add(this.dgvLista);
            this.panel1.Controls.Add(this.labelPrecio);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.labelCodigo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 442);
            this.panel1.TabIndex = 25;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(116, 199);
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(231, 399);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(45, 20);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(116, 34);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(154, 20);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(35, 37);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(63, 13);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // lblDireccion1
            // 
            this.lblDireccion1.AutoSize = true;
            this.lblDireccion1.BackColor = System.Drawing.Color.White;
            this.lblDireccion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion1.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion1.Location = new System.Drawing.Point(113, 63);
            this.lblDireccion1.Name = "lblDireccion1";
            this.lblDireccion1.Size = new System.Drawing.Size(95, 13);
            this.lblDireccion1.TabIndex = 21;
            this.lblDireccion1.Text = "Azcuenaga 185";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(383, 63);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 47);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // labelEfectivo
            // 
            this.labelEfectivo.AutoSize = true;
            this.labelEfectivo.BackColor = System.Drawing.Color.White;
            this.labelEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEfectivo.ForeColor = System.Drawing.Color.Black;
            this.labelEfectivo.Location = new System.Drawing.Point(411, 383);
            this.labelEfectivo.Name = "labelEfectivo";
            this.labelEfectivo.Size = new System.Drawing.Size(51, 13);
            this.labelEfectivo.TabIndex = 12;
            this.labelEfectivo.Text = "TOTAL:";
            // 
            // lblNumeroTicket
            // 
            this.lblNumeroTicket.AutoSize = true;
            this.lblNumeroTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNumeroTicket.Location = new System.Drawing.Point(380, 13);
            this.lblNumeroTicket.Name = "lblNumeroTicket";
            this.lblNumeroTicket.Size = new System.Drawing.Size(32, 13);
            this.lblNumeroTicket.TabIndex = 20;
            this.lblNumeroTicket.Text = "Num";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(380, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 13);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "label2";
            // 
            // txtCodProd_KeyPress
            // 
            this.txtCodProd_KeyPress.Location = new System.Drawing.Point(116, 90);
            this.txtCodProd_KeyPress.Name = "txtCodProd_KeyPress";
            this.txtCodProd_KeyPress.Size = new System.Drawing.Size(154, 20);
            this.txtCodProd_KeyPress.TabIndex = 1;
            this.txtCodProd_KeyPress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EventoEnter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(382, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 47);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.CausesValidation = false;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(383, 116);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 47);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // labelDevolucion
            // 
            this.labelDevolucion.AutoSize = true;
            this.labelDevolucion.BackColor = System.Drawing.Color.White;
            this.labelDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevolucion.ForeColor = System.Drawing.Color.Black;
            this.labelDevolucion.Location = new System.Drawing.Point(212, 383);
            this.labelDevolucion.Name = "labelDevolucion";
            this.labelDevolucion.Size = new System.Drawing.Size(87, 13);
            this.labelDevolucion.TabIndex = 13;
            this.labelDevolucion.Text = "DESCUENTO:";
            // 
            // lblTotal_Factura
            // 
            this.lblTotal_Factura.AutoSize = true;
            this.lblTotal_Factura.BackColor = System.Drawing.Color.White;
            this.lblTotal_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_Factura.ForeColor = System.Drawing.Color.Black;
            this.lblTotal_Factura.Location = new System.Drawing.Point(430, 406);
            this.lblTotal_Factura.Name = "lblTotal_Factura";
            this.lblTotal_Factura.Size = new System.Drawing.Size(11, 13);
            this.lblTotal_Factura.TabIndex = 11;
            this.lblTotal_Factura.Text = "-";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.White;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubTotal.Location = new System.Drawing.Point(40, 406);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(14, 13);
            this.lblSubTotal.TabIndex = 11;
            this.lblSubTotal.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(35, 383);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(80, 13);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "SUBTOTAL: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(113, 163);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(11, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "-";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.White;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.ForeColor = System.Drawing.Color.Black;
            this.lblProd.Location = new System.Drawing.Point(113, 129);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(11, 13);
            this.lblProd.TabIndex = 7;
            this.lblProd.Text = "-";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.BackColor = System.Drawing.Color.White;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.Black;
            this.labelCantidad.Location = new System.Drawing.Point(35, 199);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(74, 13);
            this.labelCantidad.TabIndex = 5;
            this.labelCantidad.Text = "CANTIDAD:";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.BackColor = System.Drawing.Color.White;
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.Black;
            this.labelProducto.Location = new System.Drawing.Point(35, 129);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(80, 13);
            this.labelProducto.TabIndex = 1;
            this.labelProducto.Text = "PRODUCTO:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.NombreProducto,
            this.PrecioProducto,
            this.CantidadProducto,
            this.TotalProducto});
            this.dgvLista.Location = new System.Drawing.Point(33, 226);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(460, 150);
            this.dgvLista.TabIndex = 6;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "CODIGO";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "PRODUCTO";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "PRECIO";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.HeaderText = "CANTIDAD";
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.ReadOnly = true;
            // 
            // TotalProducto
            // 
            this.TotalProducto.HeaderText = "TOTAL";
            this.TotalProducto.Name = "TotalProducto";
            this.TotalProducto.ReadOnly = true;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.White;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.Black;
            this.labelPrecio.Location = new System.Drawing.Point(35, 163);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(57, 13);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "PRECIO:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.White;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(35, 63);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "DIRECCION: ";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.BackColor = System.Drawing.Color.White;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.Black;
            this.labelCodigo.Location = new System.Drawing.Point(35, 93);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(59, 13);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "CODIGO:";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(548, 527);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.panel1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDireccion1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label labelEfectivo;
        private System.Windows.Forms.Label lblNumeroTicket;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCodProd_KeyPress;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelDevolucion;
        private System.Windows.Forms.Label lblTotal_Factura;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProducto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label labelCodigo;
    }
}