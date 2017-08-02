namespace Medicamentos_y_Suministros
{
    partial class frmMedicamentos
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
            this.txtmedicamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbreorden = new System.Windows.Forms.NumericUpDown();
            this.dtpvencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.DGMedicamentos = new System.Windows.Forms.DataGridView();
            this.idmedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reordenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donadopor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbreorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmedicamento
            // 
            this.txtmedicamento.Location = new System.Drawing.Point(132, 188);
            this.txtmedicamento.Name = "txtmedicamento";
            this.txtmedicamento.Size = new System.Drawing.Size(520, 20);
            this.txtmedicamento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad Minima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Campus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // cmbreorden
            // 
            this.cmbreorden.Location = new System.Drawing.Point(106, 214);
            this.cmbreorden.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cmbreorden.Name = "cmbreorden";
            this.cmbreorden.Size = new System.Drawing.Size(54, 20);
            this.cmbreorden.TabIndex = 1;
            // 
            // dtpvencimiento
            // 
            this.dtpvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvencimiento.Location = new System.Drawing.Point(468, 239);
            this.dtpvencimiento.Name = "dtpvencimiento";
            this.dtpvencimiento.Size = new System.Drawing.Size(184, 20);
            this.dtpvencimiento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(58, 6);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(594, 20);
            this.txtbuscar.TabIndex = 18;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // DGMedicamentos
            // 
            this.DGMedicamentos.AllowUserToAddRows = false;
            this.DGMedicamentos.AllowUserToDeleteRows = false;
            this.DGMedicamentos.AllowUserToOrderColumns = true;
            this.DGMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmedicamentos,
            this.nombre,
            this.cantidades,
            this.reordenes,
            this.donadopor,
            this.tipo,
            this.campus,
            this.fechaven});
            this.DGMedicamentos.Location = new System.Drawing.Point(15, 32);
            this.DGMedicamentos.Name = "DGMedicamentos";
            this.DGMedicamentos.ReadOnly = true;
            this.DGMedicamentos.Size = new System.Drawing.Size(637, 150);
            this.DGMedicamentos.TabIndex = 19;
            // 
            // idmedicamentos
            // 
            this.idmedicamentos.HeaderText = "Id";
            this.idmedicamentos.Name = "idmedicamentos";
            this.idmedicamentos.ReadOnly = true;
            this.idmedicamentos.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidades
            // 
            this.cantidades.HeaderText = "Cantidad";
            this.cantidades.Name = "cantidades";
            this.cantidades.ReadOnly = true;
            // 
            // reordenes
            // 
            this.reordenes.HeaderText = "Cantidad Minima";
            this.reordenes.Name = "reordenes";
            this.reordenes.ReadOnly = true;
            // 
            // donadopor
            // 
            this.donadopor.HeaderText = "Donante";
            this.donadopor.Name = "donadopor";
            this.donadopor.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo de Medicamento";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Uso del Medicamento";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(283, 213);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(369, 20);
            this.txttipo.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Donado Por:";
            // 
            // txtDonado
            // 
            this.txtDonado.Location = new System.Drawing.Point(132, 266);
            this.txtDonado.Name = "txtDonado";
            this.txtDonado.Size = new System.Drawing.Size(520, 20);
            this.txtDonado.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_meanicons_24_197210;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(496, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_200_CircledMinus_183317;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(169, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 49);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Medicamentos_y_Suministros.Properties.Resources.exit;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(577, 292);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 49);
            this.btnsalir.TabIndex = 28;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_Compose_2190985;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditar.Location = new System.Drawing.Point(88, 292);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 49);
            this.btneditar.TabIndex = 25;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Medicamentos_y_Suministros.Properties.Resources.if_199_CircledPlus_183316;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(7, 292);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 49);
            this.btnagregar.TabIndex = 24;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // cmbCampus
            // 
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Location = new System.Drawing.Point(66, 240);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(288, 21);
            this.cmbCampus.TabIndex = 29;
            // 
            // frmMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(667, 352);
            this.Controls.Add(this.cmbCampus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDonado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.DGMedicamentos);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpvencimiento);
            this.Controls.Add(this.cmbreorden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmedicamento);
            this.Name = "frmMedicamentos";
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.frmMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbreorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cmbreorden;
        private System.Windows.Forms.DateTimePicker dtpvencimiento;
        private System.Windows.Forms.BindingSource _medicamentosBindingSource;
        private System.Windows.Forms.BindingNavigator _medicamentosBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton _medicamentosBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource _medicamentosBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView DGMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn reordenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn donadopor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn campus;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaven;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonado;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cmbCampus;
    }
}

