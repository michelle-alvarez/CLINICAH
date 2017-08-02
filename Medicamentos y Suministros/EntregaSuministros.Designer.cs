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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbreorden = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmedicamento = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbreorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cantidad,
            this.reorden});
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(292, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(58, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(245, 20);
            this.txtBuscar.TabIndex = 2;
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
            // cmbreorden
            // 
            this.cmbreorden.Location = new System.Drawing.Point(249, 220);
            this.cmbreorden.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cmbreorden.Name = "cmbreorden";
            this.cmbreorden.Size = new System.Drawing.Size(54, 20);
            this.cmbreorden.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cantidad Minima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nombre Medicamento";
            // 
            // txtmedicamento
            // 
            this.txtmedicamento.Location = new System.Drawing.Point(129, 194);
            this.txtmedicamento.Name = "txtmedicamento";
            this.txtmedicamento.Size = new System.Drawing.Size(175, 20);
            this.txtmedicamento.TabIndex = 35;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 219);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cantidad";
            // 
            // btnexit
            // 
            this.btnexit.Image = global::Medicamentos_y_Suministros.Properties.Resources.exit;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexit.Location = new System.Drawing.Point(168, 305);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 49);
            this.btnexit.TabIndex = 45;
            this.btnexit.Text = "Salir";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_meanicons_24_197210;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(87, 305);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 49);
            this.btncancelar.TabIndex = 44;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_200_CircledMinus_183317;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndelete.Location = new System.Drawing.Point(210, 250);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 49);
            this.btndelete.TabIndex = 43;
            this.btndelete.Text = "Eliminar";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_Compose_2190985;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditar.Location = new System.Drawing.Point(129, 250);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 49);
            this.btneditar.TabIndex = 42;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_199_CircledPlus_183316;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(48, 250);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 49);
            this.btnagregar.TabIndex = 41;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // EntregaSuministros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 362);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbreorden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmedicamento);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EntregaSuministros";
            this.Text = "Entrada de Suministros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbreorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.NumericUpDown cmbreorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmedicamento;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncancelar;
    }
}