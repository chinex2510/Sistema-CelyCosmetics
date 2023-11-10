namespace Proyecto3.C_Presentacion
{
    partial class FrmStock
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
            this.dgv_Stock = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Proveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Stock
            // 
            this.dgv_Stock.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock.Location = new System.Drawing.Point(156, 48);
            this.dgv_Stock.Name = "dgv_Stock";
            this.dgv_Stock.Size = new System.Drawing.Size(642, 340);
            this.dgv_Stock.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Clientes);
            this.panel1.Controls.Add(this.btn_Volver);
            this.panel1.Controls.Add(this.btn_Productos);
            this.panel1.Controls.Add(this.btn_Proveedor);
            this.panel1.Location = new System.Drawing.Point(2, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 340);
            this.panel1.TabIndex = 2;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.Location = new System.Drawing.Point(16, 117);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(118, 29);
            this.btn_Clientes.TabIndex = 7;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(16, 283);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(118, 30);
            this.btn_Volver.TabIndex = 6;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Productos.Location = new System.Drawing.Point(16, 22);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(118, 30);
            this.btn_Productos.TabIndex = 5;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Proveedor
            // 
            this.btn_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proveedor.Location = new System.Drawing.Point(16, 70);
            this.btn_Proveedor.Name = "btn_Proveedor";
            this.btn_Proveedor.Size = new System.Drawing.Size(118, 29);
            this.btn_Proveedor.TabIndex = 3;
            this.btn_Proveedor.Text = "Proveedores";
            this.btn_Proveedor.UseVisualStyleBackColor = true;
            this.btn_Proveedor.Click += new System.EventHandler(this.btn_Proveedor_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Stock);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Stock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Proveedor;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Clientes;
    }
}