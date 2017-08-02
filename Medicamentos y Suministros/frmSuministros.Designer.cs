namespace Medicamentos_y_Suministros
{
    partial class frmSuministros
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
            this.txtSuministro = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.reorden = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorden)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSuministro
            // 
            this.txtSuministro.Location = new System.Drawing.Point(129, 15);
            this.txtSuministro.Name = "txtSuministro";
            this.txtSuministro.Size = new System.Drawing.Size(274, 20);
            this.txtSuministro.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(291, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "Añadir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre Suministro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad Suministro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad Reorden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(129, 41);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(274, 20);
            this.cantidad.TabIndex = 17;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(129, 92);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(274, 20);
            this.dtpVencimiento.TabIndex = 18;
            // 
            // reorden
            // 
            this.reorden.Location = new System.Drawing.Point(129, 67);
            this.reorden.Name = "reorden";
            this.reorden.Size = new System.Drawing.Size(274, 20);
            this.reorden.TabIndex = 19;
            // 
            // frmSuministros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(410, 164);
            this.Controls.Add(this.reorden);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtSuministro);
            this.Name = "frmSuministros";
            this.Text = "Suministros";
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSuministro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.BindingSource suministrosBindingSource;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.NumericUpDown reorden;
    }
}

