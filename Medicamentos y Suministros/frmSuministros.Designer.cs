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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuministros));
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonado = new System.Windows.Forms.TextBox();
            this.DGSuministros = new System.Windows.Forms.DataGridView();
            this.idsuministros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donadopor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpvencimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbreorden = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmedicamento = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGSuministros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbreorden)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCampus
            // 
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Items.AddRange(new object[] {
            "San Pedro y San Pablo",
            "Sagrado Corazón de Jesús",
            "Santiago Apóstol",
            "San Pedro y San Pablo",
            "Dios Espíritu Santo",
            "Santa Rosa de Lima",
            "Santa Clara",
            "San Isidro",
            "Jesús Sacramentado",
            "San Jorge"});
            this.cmbCampus.Location = new System.Drawing.Point(55, 211);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(231, 21);
            this.cmbCampus.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Donado Por:";
            // 
            // txtDonado
            // 
            this.txtDonado.Location = new System.Drawing.Point(85, 237);
            this.txtDonado.Name = "txtDonado";
            this.txtDonado.Size = new System.Drawing.Size(564, 20);
            this.txtDonado.TabIndex = 5;
            // 
            // DGSuministros
            // 
            this.DGSuministros.AllowUserToAddRows = false;
            this.DGSuministros.AllowUserToDeleteRows = false;
            this.DGSuministros.AllowUserToOrderColumns = true;
            this.DGSuministros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSuministros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsuministros,
            this.nombre,
            this.cantidad,
            this.reorden,
            this.donadopor,
            this.campus,
            this.fechaven});
            this.DGSuministros.Location = new System.Drawing.Point(12, 31);
            this.DGSuministros.Name = "DGSuministros";
            this.DGSuministros.ReadOnly = true;
            this.DGSuministros.Size = new System.Drawing.Size(637, 150);
            this.DGSuministros.TabIndex = 39;
            // 
            // idsuministros
            // 
            this.idsuministros.HeaderText = "Id";
            this.idsuministros.Name = "idsuministros";
            this.idsuministros.ReadOnly = true;
            this.idsuministros.Visible = false;
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
            // donadopor
            // 
            this.donadopor.HeaderText = "Donante";
            this.donadopor.Name = "donadopor";
            this.donadopor.ReadOnly = true;
            // 
            // campus
            // 
            this.campus.HeaderText = "Campus";
            this.campus.Name = "campus";
            this.campus.ReadOnly = true;
            // 
            // fechaven
            // 
            this.fechaven.HeaderText = "Fecha Vencimiento ";
            this.fechaven.Name = "fechaven";
            this.fechaven.ReadOnly = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(55, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(594, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Buscar";
            // 
            // dtpvencimiento
            // 
            this.dtpvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvencimiento.Location = new System.Drawing.Point(545, 210);
            this.dtpvencimiento.Name = "dtpvencimiento";
            this.dtpvencimiento.Size = new System.Drawing.Size(103, 20);
            this.dtpvencimiento.TabIndex = 4;
            // 
            // cmbreorden
            // 
            this.cmbreorden.Location = new System.Drawing.Point(378, 212);
            this.cmbreorden.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cmbreorden.Name = "cmbreorden";
            this.cmbreorden.Size = new System.Drawing.Size(54, 20);
            this.cmbreorden.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Campus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cantidad Minima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre Medicamento";
            // 
            // txtmedicamento
            // 
            this.txtmedicamento.Location = new System.Drawing.Point(129, 187);
            this.txtmedicamento.Name = "txtmedicamento";
            this.txtmedicamento.Size = new System.Drawing.Size(520, 20);
            this.txtmedicamento.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.Image = global::Medicamentos_y_Suministros.Properties.Resources.exit;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexit.Location = new System.Drawing.Point(574, 263);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 49);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Salir";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_meanicons_24_197210;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(493, 263);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 49);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_200_CircledMinus_183317;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndelete.Location = new System.Drawing.Point(174, 263);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 49);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Eliminar";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_Compose_2190985;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditar.Location = new System.Drawing.Point(93, 263);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 49);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_199_CircledPlus_183316;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(12, 263);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 49);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // frmSuministros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(657, 321);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.cmbCampus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDonado);
            this.Controls.Add(this.DGSuministros);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpvencimiento);
            this.Controls.Add(this.cmbreorden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmedicamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuministros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suministros";
            this.Load += new System.EventHandler(this.frmSuministros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGSuministros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbreorden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource suministrosBindingSource;
        private System.Windows.Forms.ComboBox cmbCampus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonado;
        private System.Windows.Forms.DataGridView DGSuministros;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpvencimiento;
        private System.Windows.Forms.NumericUpDown cmbreorden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmedicamento;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsuministros;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn donadopor;
        private System.Windows.Forms.DataGridViewTextBoxColumn campus;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaven;
    }
}

