namespace Proyecto3.C_Presentacion
{
    partial class FrmCantidadDevolver
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_devolver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 93);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 35);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(148, 93);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(94, 35);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(26, 45);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(194, 27);
            this.txt_Cantidad.TabIndex = 6;
            this.txt_Cantidad.ValueChanged += new System.EventHandler(this.txt_Cantidad_ValueChanged);
            // 
            // lbl_devolver
            // 
            this.lbl_devolver.AutoSize = true;
            this.lbl_devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_devolver.Location = new System.Drawing.Point(9, 9);
            this.lbl_devolver.Name = "lbl_devolver";
            this.lbl_devolver.Size = new System.Drawing.Size(233, 18);
            this.lbl_devolver.TabIndex = 5;
            this.lbl_devolver.Text = "Cuantos productos va a devolver?";
            // 
            // FrmCantidadDevolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(254, 170);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_devolver);
            this.Name = "FrmCantidadDevolver";
            this.Text = "FrmCantidadDevolver";
            this.Load += new System.EventHandler(this.FrmCantidadDevolver_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.NumericUpDown txt_Cantidad;
        private System.Windows.Forms.Label lbl_devolver;
    }
}