namespace Proyecto3.C_Presentacion
{
    partial class Form_CRUD_Prod
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
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Fecha_Vencimiento = new System.Windows.Forms.TextBox();
            this.txt_Precio_Unitario = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Prod = new System.Windows.Forms.TextBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cod_Prod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_VerStock = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(417, 234);
            this.txt_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Categoria.Multiline = true;
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(364, 27);
            this.txt_Categoria.TabIndex = 61;
            this.txt_Categoria.TextChanged += new System.EventHandler(this.txt_Categoria_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 60;
            this.label7.Text = "Categoría";
            // 
            // txt_Fecha_Vencimiento
            // 
            this.txt_Fecha_Vencimiento.Location = new System.Drawing.Point(417, 143);
            this.txt_Fecha_Vencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Fecha_Vencimiento.Multiline = true;
            this.txt_Fecha_Vencimiento.Name = "txt_Fecha_Vencimiento";
            this.txt_Fecha_Vencimiento.Size = new System.Drawing.Size(364, 27);
            this.txt_Fecha_Vencimiento.TabIndex = 59;
            this.txt_Fecha_Vencimiento.TextChanged += new System.EventHandler(this.txt_Fecha_Vencimiento_TextChanged);
            // 
            // txt_Precio_Unitario
            // 
            this.txt_Precio_Unitario.Location = new System.Drawing.Point(417, 324);
            this.txt_Precio_Unitario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Precio_Unitario.Multiline = true;
            this.txt_Precio_Unitario.Name = "txt_Precio_Unitario";
            this.txt_Precio_Unitario.Size = new System.Drawing.Size(364, 27);
            this.txt_Precio_Unitario.TabIndex = 58;
            this.txt_Precio_Unitario.TextChanged += new System.EventHandler(this.txt_Precio_Unitario_TextChanged);
            // 
            // txt_Nombre_Prod
            // 
            this.txt_Nombre_Prod.Location = new System.Drawing.Point(417, 279);
            this.txt_Nombre_Prod.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre_Prod.Multiline = true;
            this.txt_Nombre_Prod.Name = "txt_Nombre_Prod";
            this.txt_Nombre_Prod.Size = new System.Drawing.Size(364, 27);
            this.txt_Nombre_Prod.TabIndex = 57;
            this.txt_Nombre_Prod.TextChanged += new System.EventHandler(this.txt_Nombre_Prod_TextChanged);
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(417, 189);
            this.txt_Stock.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stock.Multiline = true;
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(364, 27);
            this.txt_Stock.TabIndex = 56;
            this.txt_Stock.TextChanged += new System.EventHandler(this.txt_Stock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 26);
            this.label5.TabIndex = 55;
            this.label5.Text = "Nombre Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 54;
            this.label4.Text = "Precio Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 26);
            this.label3.TabIndex = 52;
            this.label3.Text = "Código de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha de Vencimiento";
            // 
            // txt_Cod_Prod
            // 
            this.txt_Cod_Prod.Location = new System.Drawing.Point(417, 91);
            this.txt_Cod_Prod.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cod_Prod.Multiline = true;
            this.txt_Cod_Prod.Name = "txt_Cod_Prod";
            this.txt_Cod_Prod.Size = new System.Drawing.Size(364, 27);
            this.txt_Cod_Prod.TabIndex = 50;
            this.txt_Cod_Prod.TextChanged += new System.EventHandler(this.txt_Cod_Prod_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(372, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 37);
            this.label6.TabIndex = 49;
            this.label6.Text = "Registrar Productos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btn_VerStock);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 450);
            this.panel1.TabIndex = 48;
            // 
            // btn_VerStock
            // 
            this.btn_VerStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerStock.Location = new System.Drawing.Point(24, 374);
            this.btn_VerStock.Margin = new System.Windows.Forms.Padding(2);
            this.btn_VerStock.Name = "btn_VerStock";
            this.btn_VerStock.Size = new System.Drawing.Size(119, 35);
            this.btn_VerStock.TabIndex = 37;
            this.btn_VerStock.Text = "Ver Stock";
            this.btn_VerStock.UseVisualStyleBackColor = true;
            this.btn_VerStock.Click += new System.EventHandler(this.btn_VerStock_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(24, 88);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(119, 35);
            this.btn_Limpiar.TabIndex = 36;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(24, 26);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(119, 35);
            this.btn_Buscar.TabIndex = 35;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(24, 145);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(119, 35);
            this.btn_Modificar.TabIndex = 31;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(24, 198);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(119, 35);
            this.btn_Eliminar.TabIndex = 32;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(24, 250);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(119, 35);
            this.btn_Guardar.TabIndex = 33;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(24, 308);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(119, 35);
            this.btn_Cancelar.TabIndex = 34;
            this.btn_Cancelar.Text = "Volver";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form_CRUD_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Categoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Fecha_Vencimiento);
            this.Controls.Add(this.txt_Precio_Unitario);
            this.Controls.Add(this.txt_Nombre_Prod);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cod_Prod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Form_CRUD_Prod";
            this.Text = "Form_CRUD_Prod";
            this.Load += new System.EventHandler(this.Form_CRUD_Prod_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Fecha_Vencimiento;
        private System.Windows.Forms.TextBox txt_Precio_Unitario;
        private System.Windows.Forms.TextBox txt_Nombre_Prod;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cod_Prod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_VerStock;
    }
}