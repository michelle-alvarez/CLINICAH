namespace Medicamentos_y_Suministros
{
    partial class EntregaSuministros
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.nmbcantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmbreorden = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmedicamento = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGMedicamentos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmbcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbreorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Image = global::Medicamentos_y_Suministros.Properties.Resources.exit;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexit.Location = new System.Drawing.Point(227, 248);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 49);
            this.btnexit.TabIndex = 71;
            this.btnexit.Text = "Salir";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_meanicons_24_197210;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(119, 248);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 49);
            this.btncancelar.TabIndex = 70;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_199_CircledPlus_183316;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(14, 248);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 49);
            this.btnagregar.TabIndex = 69;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // nmbcantidad
            // 
            this.nmbcantidad.Location = new System.Drawing.Point(66, 221);
            this.nmbcantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbcantidad.Name = "nmbcantidad";
            this.nmbcantidad.Size = new System.Drawing.Size(54, 20);
            this.nmbcantidad.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Cantidad";
            // 
            // nmbreorden
            // 
            this.nmbreorden.Location = new System.Drawing.Point(248, 222);
            this.nmbreorden.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbreorden.Name = "nmbreorden";
            this.nmbreorden.Size = new System.Drawing.Size(54, 20);
            this.nmbreorden.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Cantidad Minima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Nombre Medicamento";
            // 
            // txtmedicamento
            // 
            this.txtmedicamento.Location = new System.Drawing.Point(128, 196);
            this.txtmedicamento.Name = "txtmedicamento";
            this.txtmedicamento.Size = new System.Drawing.Size(175, 20);
            this.txtmedicamento.TabIndex = 63;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(57, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(245, 20);
            this.txtBuscar.TabIndex = 62;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Buscar";
            // 
            // DGMedicamentos
            // 
            this.DGMedicamentos.AllowUserToAddRows = false;
            this.DGMedicamentos.AllowUserToDeleteRows = false;
            this.DGMedicamentos.AllowUserToOrderColumns = true;
            this.DGMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cantidad,
            this.reorden});
            this.DGMedicamentos.Location = new System.Drawing.Point(11, 37);
            this.DGMedicamentos.Name = "DGMedicamentos";
            this.DGMedicamentos.ReadOnly = true;
            this.DGMedicamentos.RowHeadersWidth = 20;
            this.DGMedicamentos.Size = new System.Drawing.Size(292, 150);
            this.DGMedicamentos.TabIndex = 60;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // reorden
            // 
            this.reorden.HeaderText = "Cantidad Minima";
            this.reorden.Name = "reorden";
            this.reorden.ReadOnly = true;
            // 
            // EntregaSuministros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 309);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.nmbcantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmbreorden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmedicamento);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGMedicamentos);
            this.Name = "EntregaSuministros";
            this.Text = "Entrada de Suministros";
            this.Load += new System.EventHandler(this.EntregaSuministros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbreorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.NumericUpDown nmbcantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmbreorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmedicamento;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorden;
    }
}