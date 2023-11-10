namespace Proyecto3.C_Presentacion
{
    partial class Frm_Devoluciones
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
            this.lbl_Valor_Total = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_Devolucion = new System.Windows.Forms.Button();
            this.dgv_Detalle_Recibo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle_Recibo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Valor_Total
            // 
            this.lbl_Valor_Total.AutoSize = true;
            this.lbl_Valor_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor_Total.Location = new System.Drawing.Point(303, 373);
            this.lbl_Valor_Total.Name = "lbl_Valor_Total";
            this.lbl_Valor_Total.Size = new System.Drawing.Size(54, 20);
            this.lbl_Valor_Total.TabIndex = 12;
            this.lbl_Valor_Total.Text = "12345";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(228, 373);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(81, 20);
            this.lbl_Total.TabIndex = 11;
            this.lbl_Total.Text = "Total:      $";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(10, 33);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(109, 27);
            this.btn_Volver.TabIndex = 10;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(129, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(147, 21);
            this.lbl_titulo.TabIndex = 9;
            this.lbl_titulo.Text = "Detalle de Recibo";
            // 
            // btn_Devolucion
            // 
            this.btn_Devolucion.Location = new System.Drawing.Point(10, 318);
            this.btn_Devolucion.Name = "btn_Devolucion";
            this.btn_Devolucion.Size = new System.Drawing.Size(347, 34);
            this.btn_Devolucion.TabIndex = 8;
            this.btn_Devolucion.Text = "Devolver Aticulo Seleccionado";
            this.btn_Devolucion.UseVisualStyleBackColor = true;
            this.btn_Devolucion.Click += new System.EventHandler(this.btn_Devolucion_Click);
            // 
            // dgv_Detalle_Recibo
            // 
            this.dgv_Detalle_Recibo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Detalle_Recibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detalle_Recibo.Location = new System.Drawing.Point(10, 66);
            this.dgv_Detalle_Recibo.Name = "dgv_Detalle_Recibo";
            this.dgv_Detalle_Recibo.Size = new System.Drawing.Size(347, 246);
            this.dgv_Detalle_Recibo.TabIndex = 7;
            this.dgv_Detalle_Recibo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detalle_Recibo_CellClick);
            // 
            // Frm_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.lbl_Valor_Total);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_Devolucion);
            this.Controls.Add(this.dgv_Detalle_Recibo);
            this.Name = "Frm_Devoluciones";
            this.Text = "Frm_Devoluciones";
            this.Load += new System.EventHandler(this.Frm_Devoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle_Recibo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Valor_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_Devolucion;
        private System.Windows.Forms.DataGridView dgv_Detalle_Recibo;
    }
}