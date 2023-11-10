namespace Proyecto3.C_Presentacion
{
    partial class FrmRegistroVentas
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
            this.btn_Detalle = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.txt_Num_Recibo = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_texto_busqueda = new System.Windows.Forms.Label();
            this.dgvHistorialVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Detalle
            // 
            this.btn_Detalle.Location = new System.Drawing.Point(117, 70);
            this.btn_Detalle.Name = "btn_Detalle";
            this.btn_Detalle.Size = new System.Drawing.Size(93, 37);
            this.btn_Detalle.TabIndex = 11;
            this.btn_Detalle.Text = "Detalle";
            this.btn_Detalle.UseVisualStyleBackColor = true;
            this.btn_Detalle.Click += new System.EventHandler(this.btn_Detalle_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(18, 70);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(93, 37);
            this.btn_Volver.TabIndex = 10;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // txt_Num_Recibo
            // 
            this.txt_Num_Recibo.Location = new System.Drawing.Point(249, 41);
            this.txt_Num_Recibo.Name = "txt_Num_Recibo";
            this.txt_Num_Recibo.Size = new System.Drawing.Size(119, 20);
            this.txt_Num_Recibo.TabIndex = 9;
            this.txt_Num_Recibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Num_Recibo.TextChanged += new System.EventHandler(this.txt_Num_Recibo_TextChanged);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(92, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(166, 21);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = " Historial de Ventas";
            // 
            // lbl_texto_busqueda
            // 
            this.lbl_texto_busqueda.AutoSize = true;
            this.lbl_texto_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto_busqueda.Location = new System.Drawing.Point(15, 42);
            this.lbl_texto_busqueda.Name = "lbl_texto_busqueda";
            this.lbl_texto_busqueda.Size = new System.Drawing.Size(219, 15);
            this.lbl_texto_busqueda.TabIndex = 7;
            this.lbl_texto_busqueda.Text = "Puede buscar el recibo por su numero:";
            // 
            // dgvHistorialVenta
            // 
            this.dgvHistorialVenta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvHistorialVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialVenta.Location = new System.Drawing.Point(8, 128);
            this.dgvHistorialVenta.Name = "dgvHistorialVenta";
            this.dgvHistorialVenta.Size = new System.Drawing.Size(360, 280);
            this.dgvHistorialVenta.TabIndex = 6;
            this.dgvHistorialVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialVenta_CellClick_1);
            // 
            // FrmRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.btn_Detalle);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.txt_Num_Recibo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_texto_busqueda);
            this.Controls.Add(this.dgvHistorialVenta);
            this.Name = "FrmRegistroVentas";
            this.Text = "FrmRegistroVentas";
            this.Load += new System.EventHandler(this.FrmRegistroVentas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Detalle;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.TextBox txt_Num_Recibo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_texto_busqueda;
        private System.Windows.Forms.DataGridView dgvHistorialVenta;
    }
}